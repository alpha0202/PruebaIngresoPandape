using PruebaIngreso.DTO;
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
    public class GetDetailsCandidateInteractor : IGetDetailsCandidateInputPort
    {
        private readonly ICandidatesRepository _candidatesRepository;
        private readonly IGetDetailsCandidateOutputPort _outputPortGetDetails;

        public GetDetailsCandidateInteractor(ICandidatesRepository candidatesRepository, IGetDetailsCandidateOutputPort outputPortGetDetails)
        {
            _candidatesRepository = candidatesRepository;
            _outputPortGetDetails = outputPortGetDetails;
        }

        public async void Handler(int Id)
        {
            CandidateDTO resDetail = await _candidatesRepository.GetDatailCandidates(Id);
            _outputPortGetDetails.Handler(resDetail);
        }
    }
}
