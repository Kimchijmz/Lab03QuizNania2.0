using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03QuizNania2._0.Models
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answer { get; set; }
        public int CorrectAnswer { get; set; }
        public string Category { get; set; }
        public string? ImagePath { get; set; }

        public Question(string questionText, string[] answer, int correctAnswer, string category, string imagePath)
        {
            QuestionText = questionText;
            Answer = answer;
            CorrectAnswer = correctAnswer;
            Category = category;
            ImagePath = imagePath;
        }


    }
}
