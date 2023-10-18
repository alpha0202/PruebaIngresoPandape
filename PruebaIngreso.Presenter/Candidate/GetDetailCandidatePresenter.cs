using PruebaIngreso.DTO;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter.Candidate
{
    public class GetDetailCandidatePresenter : IGetDetailsCandidateOutputPort, IPresenter<CandidateDTO>
    {
        public CandidateDTO Content { get; private set; }


        public void Handler(CandidateDTO candidateDetailDTO)
        {
            Content = candidateDetailDTO;
        }
    }
}
