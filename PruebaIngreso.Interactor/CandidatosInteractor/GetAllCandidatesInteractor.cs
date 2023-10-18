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
    public class GetAllCandidatesInteractor : IGetAllCandidatesInputPort
    {
        private readonly ICandidatesRepository _candidatesRepository;
        private readonly IGetAllCandidatesOutputPort _OutputPort;

        public GetAllCandidatesInteractor(ICandidatesRepository candidatesRepository, IGetAllCandidatesOutputPort getAllCandidatesOutputPort)
        {
            _candidatesRepository = candidatesRepository;
            _OutputPort = getAllCandidatesOutputPort;
        }

        public async void Handler()
        {
           IEnumerable<CandidateDTO> res = await _candidatesRepository.GetAllCandidates();
            _OutputPort.Handler(res);
        }
    }
}
