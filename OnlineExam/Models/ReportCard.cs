using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class ReportCard
    {
        public int? Marks { get; set; }
        public string ExamLevel { get; set; }
        public string ExamSpec { get; set; }
    }
}
