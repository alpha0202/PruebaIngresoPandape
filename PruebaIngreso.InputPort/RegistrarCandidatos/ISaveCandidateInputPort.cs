using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.InputPort.RegistrarCandidatos
{
    public interface ISaveCandidateInputPort
    {
        public void Handler(Candidate candidate);
    }
}
