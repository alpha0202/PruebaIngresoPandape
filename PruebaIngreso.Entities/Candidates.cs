using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Entities
{
    public class Candidates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public HashSet<CandidateExperiences> CandidateExperiences { get; set; }


    }
}
