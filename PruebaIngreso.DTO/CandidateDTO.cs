using PruebaIngreso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.DTO
{
    public class CandidateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public DateTime InsertDate { get; set; }
        public ICollection<CandidateExperiencesDTO> CandidateExperiences { get; set; }


    }
}
