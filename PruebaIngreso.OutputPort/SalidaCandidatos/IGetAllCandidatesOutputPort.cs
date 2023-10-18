using PruebaIngreso.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.OutputPort.SalidaCandidatos
{
    public interface IGetAllCandidatesOutputPort
    {
        public void Handler(IEnumerable<CandidateDTO> candidatesDTOs);
    }
}
