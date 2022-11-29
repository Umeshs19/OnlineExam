using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class Admin_Profile
    {
        public int Adminid { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AdminDob { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
