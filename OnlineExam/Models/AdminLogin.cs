using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class AdminLogin
    {
        public int Adminid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
