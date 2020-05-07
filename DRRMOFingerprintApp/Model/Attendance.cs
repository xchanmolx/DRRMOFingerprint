namespace DRRMOFingerprintApp.Model
{
    public class Attendance
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string OfficeName { get; set; }
        public string Designation { get; set; }
        public string LocalDate { get; set; }
        public byte[] Signature { get; set; }
    }
}
