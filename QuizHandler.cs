using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace JSONTest
{
    public class QuizHandler
    {
        public Quiz CurrentQuiz { get; set; }
        public int CurrentQuestion { get; set; }
        public int CurrentScore { get; set; }
        
        public QuizHandler()
        {
           Question nextQuestion = CurrentQuiz.questions[0];
            if (nextQuestion.type == "slidingOption")
            {
                PushVC(1);
            }
            else if (nextQuestion.type == ""){
                
            }
        }
        public void PushVC(int VCType){
            
        }  

        
    }
}
