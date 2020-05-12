namespace DRRMOFingerprintApp.Model
{
    public class Fingerprint
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public byte[] FingerprintPerson { get; set; }
    }
}
