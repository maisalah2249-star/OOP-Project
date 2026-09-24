using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Models
{
    public class MCQQuestion : Question
    {
        public MCQQuestion()
        {
        }

        public MCQQuestion(
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
            return $"MCQ Question: {Body} - Mark: {Mark}";
        }
    }
}
