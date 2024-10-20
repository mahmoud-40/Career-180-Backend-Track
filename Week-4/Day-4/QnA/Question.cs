using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnA
{
    class Question
    {
        public string QuestionText { get; set; }
        public int Marks { get; set; }

        public Question(string questionText, int marks)
        {
            QuestionText = questionText;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"{QuestionText} : ({Marks} marks)";
        }
    }
}
