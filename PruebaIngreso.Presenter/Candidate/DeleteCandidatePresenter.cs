using PruebaIngreso.OutputPort.SalidaCandidatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter.Candidate
{
    public class DeleteCandidatePresenter : IDeleteCandidateOutputPort, IPresenter<int>
    {
        public int Content { get; private set; }

        public void Handler(int id)
        {
            Content = id;
        }
    }
}
