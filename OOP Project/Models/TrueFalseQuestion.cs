using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Models
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
        }

        public TrueFalseQuestion(
            string header,
            string body,
            int mark,
            Answer[] answers,
            Answer rightAnswer)
            : base(header, body, mark)
        {
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");

            foreach (Answer answer in AnswerList)
            {
                Console.WriteLine(answer);
            }

            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"True/False Question: {Body} - Mark: {Mark}";
        }
    }
}
