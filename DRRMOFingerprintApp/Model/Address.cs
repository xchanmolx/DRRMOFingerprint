namespace DRRMOFingerprintApp.Model
{
    public class Address
    {
        public int PersonId { get; set; }
        public string HomeAddress { get; set; }
        public string Town { get; set; }
        public string Barangay { get; set; }
        public string Sitio { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
