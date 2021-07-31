using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QNA.Models
{
    public class Answer
    {
        [Key]
        [DisplayName("Answer ID")]
        public int AnswerId { get; set; }

        [DisplayName("Question ID")]
        public int QuestionId { get; set; }

        [DisplayName("Answer")]
        public string AnswerText { get; set; }

        [DisplayName("Last Updated")]
        public DateTime AnswerDateAndTime { get; set; }

        [DisplayName("Posted By")]
        public String name { get; set; }

        public virtual Question Question { get; set; }
    }
}

