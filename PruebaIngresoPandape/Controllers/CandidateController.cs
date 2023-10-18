using Microsoft.AspNetCore.Mvc;
using PruebaIngreso.DTO;
using PruebaIngreso.Entities;
using PruebaIngreso.Repository;

namespace PruebaIngresoPandape.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ICandidatesRepository _candidatesRepository;

        public CandidateController(ICandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public  async Task<IEnumerable<CandidateDTO>> GetCandidates()
        {
            return await _candidatesRepository.GetAllCandidates();

        }




        public async Task<CandidateDTO> GetDatailCandidates(int Id)
        {
            return await _candidatesRepository.GetDatailCandidates(Id);
        }



        //save
        public async Task<bool> SaveCandidate(Candidate candidate)
        {
            try
            {
                if(candidate.Id == 0)
                {
                    await _candidatesRepository.SaveCandidate(candidate);
                    return true;
                }
                else
                {
                    await _candidatesRepository.UpdateCandidate(candidate);

                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
            
            
        }




        public async Task<int> DeleteCandidate(int Id)
        {
            int res = 0;

            try
            {
                await  _candidatesRepository.DeleteCandidate(Id);
                res = 1; 

            }
            catch (Exception ex)
            {

                res = 0;
                throw new Exception(ex.Message);
            }

            return res;
        }
    }
}
