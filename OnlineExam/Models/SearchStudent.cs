using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class SearchStudent
    {
        public string Technology { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Levels { get; set; }
        public int Marks { get; set; }
    }
}
