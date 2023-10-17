using AutoMapper;
using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.DTO.services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Candidate, CandidateDTO>();

            CreateMap<CandidateExperiences, CandidateExperiencesDTO>();
        }


    }
}
