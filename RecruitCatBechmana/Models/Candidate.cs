using System;

namespace RecruitCatBechmana.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? TargetSalary { get; set; }
        public DateTime? CandOptStartDate { get; set; }
        public Boolean Hired { get; set;  }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Company CompAssociated { get; set; }
        public int CompAssociatedId { get; set; }
        public Job_Title TitleAssociated { get; set; }
        public int TitleAssociatedId { get; set; }
        public Industry IndAssociated { get; set; }
        public int IndAssociatedId { get; set; }
    }
}
