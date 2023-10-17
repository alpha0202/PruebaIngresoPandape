using PruebaIngreso.DTO;
using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Repository
{
    public interface ICandidatesRepository
    {
        Task<IEnumerable<CandidateDTO>> GetAllCandidates();

        Task<CandidateDTO> GetDatailCandidates(int Id);

        Task SaveCandidate(Candidate candidate);

        Task UpdateCandidate(Candidate candidate);
        
        Task DeleteCandidate(int Id);
    }
}
