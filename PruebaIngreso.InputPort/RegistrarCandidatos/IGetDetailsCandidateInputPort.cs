using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.InputPort.RegistrarCandidatos
{
    public interface IGetDetailsCandidateInputPort
    {
        public void Handler(int Id);
    }
}
