using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class Registration
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Qualification { get; set; }
        public string YearOfCompletion { get; set; }
    }
}
