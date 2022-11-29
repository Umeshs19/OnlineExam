using System;
using System.Collections.Generic;
using OnlineExam.Models;

#nullable disable

namespace OnlineExam.Models
{
    public partial class Login
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual Registration User { get; set; }
    }
}
