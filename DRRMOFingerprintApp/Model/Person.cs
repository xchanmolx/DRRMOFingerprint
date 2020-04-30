using System.ComponentModel.DataAnnotations;

namespace DRRMOFingerprintApp.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ExtensionName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Remarks { get; set; }
        public string StringImage { get; set; }
    }
}
