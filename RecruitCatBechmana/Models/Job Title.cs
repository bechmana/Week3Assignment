using System.Collections.Generic;

namespace RecruitCatBechmana.Models
{
    public class Job_Title
    {
        public int TitleId { get; set; }
        public decimal TitleMinSalary { get; set; }
        public decimal TitleMaxSalary { get; set; }
        public decimal TitleMedianSalary { get; set; }
        public List<Candidate> Candidate { get; set; }
    }
}
