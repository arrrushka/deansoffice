namespace DeansOffice.Logic.DTOs
{
    public class NewDocumentDTO
    {
        public long RequestId { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentData { get; set; }
    }
}
