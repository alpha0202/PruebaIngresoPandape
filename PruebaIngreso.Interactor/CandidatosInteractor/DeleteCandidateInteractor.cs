using PruebaIngreso.InputPort.RegistrarCandidatos;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using PruebaIngreso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Interactor.CandidatosInteractor
{
    public class DeleteCandidateInteractor : IDeleteCandidateInputPort
    {
        private readonly ICandidatesRepository _candidatesRepository;
        private readonly IDeleteCandidateOutputPort _outputPortDelete;

        public DeleteCandidateInteractor(ICandidatesRepository candidatesRepository, IDeleteCandidateOutputPort outputPortDelete)
        {
            _candidatesRepository = candidatesRepository;
            _outputPortDelete = outputPortDelete;
        }

        public async void Handler(int Id)
        {
            int res = 0;

            try
            {
                await _candidatesRepository.DeleteCandidate(Id);
                res = 1;

            }
            catch (Exception ex)
            {

                res = 0;
                throw new Exception(ex.Message);
            }

           _outputPortDelete.Handler(res);




            //int resDelete = await _candidatesRepository.DeleteCandidate(Id);
            //_outputPortDelete.Handler(resDelete);

        }
    }
}
