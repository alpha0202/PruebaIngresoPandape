using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PruebaIngreso.Data;
using PruebaIngreso.DTO;
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
        private readonly IMapper _mapper;

        public CandidatesRepository(MyDbContext myDbContext, IMapper mapper)
        {
            _myDbContext = myDbContext;
            _mapper = mapper;
        }

        //get all
        public async Task<IEnumerable<CandidateDTO>> GetAllCandidates()
        {
            //return await _myDbContext.Candidates.Include(e => e.CandidateExperiences).ToListAsync();
            return await _myDbContext.Candidates.ProjectTo<CandidateDTO>(_mapper.ConfigurationProvider).ToListAsync();
            
        }

        //get details
        public async Task<Candidates> GetDatailCandidates(int Id)
        {
            var Candidate = await _myDbContext.Candidates.Include(c=> c.CandidateExperiences).FirstOrDefaultAsync(e => e.Id == Id);
            if(Candidate == null)
            {
                 throw new Exception("Candidate does not exist");
            }
            return Candidate;
        }


        //insert candidate
        public async Task SaveCandidate(Candidates candidate)
        {
            if (candidate.CandidateExperiences == null)
            {
                throw new Exception("Candidate should have at least one expirence");
            }

            await _myDbContext.AddAsync(candidate);
            await _myDbContext.AddRangeAsync(candidate.CandidateExperiences);
            await _myDbContext.SaveChangesAsync();

        }



        //update
        public async Task UpdateCandidate(Candidates candidate)
        {
            if (candidate == null)
                throw new Exception("No data to update");

            var existingCandidate = await _myDbContext.Candidates.Include(e => e.CandidateExperiences).FirstOrDefaultAsync(o =>  o.Id == candidate.Id);
            if(existingCandidate == null)
              throw new Exception("candidate is not found");
           

            existingCandidate.Name = candidate.Name;
            existingCandidate.BirthDate = candidate.BirthDate;
            existingCandidate.SurName = candidate.SurName;
            existingCandidate.Email = candidate.Email;
            existingCandidate.InsertDate = candidate.InsertDate;
            existingCandidate.ModifyDate = candidate.ModifyDate;

            _myDbContext.CandidateExperiences.RemoveRange(existingCandidate.CandidateExperiences);

            _myDbContext.Candidates.Update(existingCandidate);
            _myDbContext.CandidateExperiences.AddRange(candidate.CandidateExperiences);

            await _myDbContext.SaveChangesAsync();


            
        }


        //delete candidate and experiences
        public async Task DeleteCandidate(int Id)
        {
            var delExistingCandidate = await _myDbContext.Candidates.Include(e => e.CandidateExperiences).FirstOrDefaultAsync(o => o.Id ==Id);

            if (delExistingCandidate == null)
                throw new Exception("canditate is not found");
            _myDbContext.CandidateExperiences.RemoveRange(delExistingCandidate.CandidateExperiences);
            _myDbContext.Candidates.Remove(delExistingCandidate); 
            await _myDbContext.SaveChangesAsync();

        }

    }
}
