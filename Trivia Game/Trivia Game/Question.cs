using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class TriviaItem
    {
        //Question Elements

        public string QuestionText;
        public string Answer;
        string Category;
        int Difficulty = 0;
        int Points;


        public string Show()
        {
            return QuestionText;
        }

        public void Check() { }




    }
}