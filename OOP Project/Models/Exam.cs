using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Models
{
    public abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        protected Exam()
        {
            Questions = new Question[0];
        }

        protected Exam(int time, int numberOfQuestions)
            : this()
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Exam Time: {Time} minutes, Questions: {NumberOfQuestions}";
        }
    }
}
