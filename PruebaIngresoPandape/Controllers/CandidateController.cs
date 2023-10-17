using Microsoft.AspNetCore.Mvc;
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

        public  async Task<IEnumerable<Candidates>> GetCandidates()
        {
            return await _candidatesRepository.GetAllCandidates();

        }


        public async Task<Candidates> GetDatailCandidates(int Id)
        {
            return await _candidatesRepository.GetDatailCandidates(Id);
        }

    }
}
