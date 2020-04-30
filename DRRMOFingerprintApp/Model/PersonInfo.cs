using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRRMOFingerprintApp.Model
{
    public class PersonInfo
    {
        public int PersonId { get; set; }
        public string Nickname { get; set; }
        public string CivilStatus { get; set; }
        public string BirthPlace { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Religion { get; set; }
        public string IdentifyingMarks { get; set; }
        public string DateAdded { get; set; }
        public int Age { get; set; }
    }
}
