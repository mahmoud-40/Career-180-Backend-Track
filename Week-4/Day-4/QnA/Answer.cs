using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnA
{
    class Answer
    {
        public int Number { get; set; }
        public string ChooseText { get; set; }

        public Answer(int number, string chooseText)
        {
            Number = number;
            ChooseText = chooseText;
        }

        public override string ToString()
        {
            return $"{Number}. {ChooseText}";
        }

    }
}
