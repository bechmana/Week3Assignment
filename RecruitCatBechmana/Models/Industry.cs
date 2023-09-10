using System.Collections.Generic;

namespace RecruitCatBechmana.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public List<Candidate> Candidate { get; set; }
        public List<Company> Company { get; set; }
    }
}
