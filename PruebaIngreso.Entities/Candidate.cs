using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "Date")]
        public DateTime InsertDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime ModifyDate { get; set; }

        public HashSet<CandidateExperiences> CandidateExperiences { get; set; }


    }
}
