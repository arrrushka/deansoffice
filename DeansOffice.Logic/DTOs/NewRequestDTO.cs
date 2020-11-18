using DeansOffice.Domain.Models;
using System.Collections.Generic;

namespace DeansOffice.Logic.DTOs
{
    public class NewRequestDTO
    {
        public long SenderId { get; set; }
        public DocumentType Type { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
