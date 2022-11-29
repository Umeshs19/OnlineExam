using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineExam.Models
{
    public partial class Get_Question
    {
        public int QuestionId { get; set; }
        public string ExamSpecialization { get; set; }
        public string ExamLevel { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
    }
}
