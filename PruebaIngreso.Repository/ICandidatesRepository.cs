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
        Task<IEnumerable<Candidates>> GetAllCandidates();

        Task<Candidates> GetDatailCandidates(int Id);

        Task SaveCandidate(Candidates candidate);

        Task UpdateCandidate(Candidates candidate);
        
        Task DeleteCandidate(int Id);
    }
}
