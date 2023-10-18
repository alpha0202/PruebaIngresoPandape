using PruebaIngreso.DTO;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter.Candidate
{
    public class GetAllCandidatePresenter : IGetAllCandidatesOutputPort, IPresenter<IEnumerable<CandidateDTO>>
    {
        public IEnumerable<CandidateDTO> Content { get; private set; }

        public void Handler(IEnumerable<CandidateDTO> candidatesDTOs)
        {
           Content = candidatesDTOs;
        }

    }
}
