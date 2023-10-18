using PruebaIngreso.OutputPort.SalidaCandidatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter.Candidate
{
    internal class SaveCandidatePresenter : ISaveCandidateOutputPort, IPresenter<bool>
    {
        public bool Content { get; private set; }

        public void Handler(bool res)
        {
           Content = res;
        }
    }
}
