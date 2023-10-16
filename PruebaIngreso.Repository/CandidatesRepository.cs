using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PruebaIngreso.Data;
using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Repository
{
    public class CandidatesRepository : ICandidatesRepository
    {
        private readonly MyDbContext _myDbContext;

        public CandidatesRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IEnumerable<Candidates>> GetAllCandidates()
        {
            return await _myDbContext.Candidates.Include(e => e.CandidateExperiences).ToListAsync();
        }

        public async Task<Candidates> GetDatailCandidates(int Id)
        {
            var Candidate = await _myDbContext.Candidates.Include(c=> c.CandidateExperiences).FirstOrDefaultAsync(e => e.Id == Id);
            if(Candidate == null)
            {
                 ;
            }
            return Candidate;
        }

        public Task SaveCandidate(Candidates candidate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCandidate(Candidates candidate)
        {
            throw new NotImplementedException();
        }
        public Task DeleteCandidate(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
