using Microsoft.AspNetCore.Mvc;
using PruebaIngreso.DTO;
using PruebaIngreso.Entities;
using PruebaIngreso.InputPort.RegistrarCandidatos;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using PruebaIngreso.Presenter;
using PruebaIngreso.Repository;
using System.Collections.Generic;

namespace PruebaIngresoPandape.Controllers
{
    public class CandidateController : Controller
    {
        private readonly IGetAllCandidatesInputPort _inputPortGetAll;
        private readonly IGetAllCandidatesOutputPort _outputPortGetAll;
        private readonly IGetDetailsCandidateInputPort _inputPortGetDetail;
        private readonly IGetDetailsCandidateOutputPort _outputPortGetDatail;
        private readonly IDeleteCandidateInputPort _inputPortDelete;
        private readonly IDeleteCandidateOutputPort _outputPortDelete;
        private readonly ISaveCandidateInputPort _inputPortSave;
        private readonly ISaveCandidateOutputPort _outputPortSave;

        public CandidateController(IGetAllCandidatesInputPort inputPortGetAll, 
                                   IGetAllCandidatesOutputPort outputPortGetAll,
                                   IGetDetailsCandidateInputPort inputPortGetDetail,
                                   IGetDetailsCandidateOutputPort outputPortGetDatail,
                                   IDeleteCandidateInputPort inputPortDelete,
                                   IDeleteCandidateOutputPort outputPortDelete,
                                   ISaveCandidateInputPort inputPortSave,
                                   ISaveCandidateOutputPort outputPortSave)
        {
            _inputPortGetAll = inputPortGetAll;
            _outputPortGetAll = outputPortGetAll;
            _inputPortGetDetail = inputPortGetDetail;
            _outputPortGetDatail = outputPortGetDatail;
            _inputPortDelete = inputPortDelete;
            _outputPortDelete = outputPortDelete;
            _inputPortSave = inputPortSave;
            _outputPortSave = outputPortSave;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IEnumerable<CandidateDTO>> GetCandidates()
        {
           _inputPortGetAll.Handler();
            return  ((IPresenter<IEnumerable<CandidateDTO>>)_outputPortGetAll).Content;

        }

        public async Task<CandidateDTO> GetDatailCandidates(int Id)
        {
            _inputPortGetDetail.Handler(Id);
            return ((IPresenter<CandidateDTO>)_outputPortGetDatail).Content;
        }


        public async Task<int> DeleteCandidate(int Id)
        {
            _inputPortDelete.Handler(Id);
            return ((IPresenter<int>)_outputPortDelete).Content;
        }

        public async Task<bool> SaveCandidate(Candidate candidate)
        {
            _inputPortSave.Handler(candidate);
            return((IPresenter<bool>)_outputPortSave).Content;
              
        }


        #region formato tradicional del acciones del controlador
        //private readonly ICandidatesRepository _candidatesRepository;

        //public CandidateController(ICandidatesRepository candidatesRepository)
        //{
        //    _candidatesRepository = candidatesRepository;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public  async Task<IEnumerable<CandidateDTO>> GetCandidates()
        //{
        //    return await _candidatesRepository.GetAllCandidates();

        //}




        //public async Task<CandidateDTO> GetDatailCandidates(int Id)
        //{
        //    return await _candidatesRepository.GetDatailCandidates(Id);
        //}



        ////save
        //public async Task<bool> SaveCandidate(Candidate candidate)
        //{
        //    try
        //    {
        //        if(candidate.Id == 0)
        //        {
        //            await _candidatesRepository.SaveCandidate(candidate);
        //            return true;
        //        }
        //        else
        //        {
        //            await _candidatesRepository.UpdateCandidate(candidate);

        //            return true;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        throw new Exception(ex.Message);
        //    }


        //}




        //public async Task<int> DeleteCandidate(int Id)
        //{
        //    int res = 0;

        //    try
        //    {
        //        await  _candidatesRepository.DeleteCandidate(Id);
        //        res = 1; 

        //    }
        //    catch (Exception ex)
        //    {

        //        res = 0;
        //        throw new Exception(ex.Message);
        //    }

        //    return res;
        //}
        #endregion
    }
}
