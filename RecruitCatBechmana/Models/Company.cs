using System;
using System.Collections.Generic;

namespace RecruitCatBechmana.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PostionName { get; set; }
        public decimal CompMinSalary { get; set; }
        public decimal CompMaxSalary { get; set; }
        public DateTime? CompOptStartDate { get; set; }
        public string Location { get; set; }
        public int? CompRating { get; set; }
        public string CompDescription { get; set; }
        public Boolean PositionFilled { get; set; }
        public List<Candidate> Candidate { get; set; }
        public Industry IndAssociated { get; set; }
        public int IndAssociatedId { get; set; }
    }
}
