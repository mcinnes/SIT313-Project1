﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONTest
{
    public class QuizHandler
    {
        public Quiz CurrentQuiz { get; set; }
        public int CurrentQuestion { get; set; }
        public int CurrentScore { get; set; }
        private static QuizHandler instance = null;
        
        
        public void setQuiz(Quiz quiz){
            CurrentQuiz = quiz;
            Question nextQuestion = CurrentQuiz.questions[4];
            
        }
        public QuizHandler(){
          CurrentQuestion = 4;
        }
        public Question GetQuestion(){
            return CurrentQuiz.questions[CurrentQuestion];
        }  
        public void CheckAnswer(){

        }
        public Question StartQuiz(){
            return CurrentQuiz.questions[CurrentQuestion];
        }
        
        public String NextQuestion(){
            CurrentQuestion++;

            if (CurrentQuestion <= CurrentQuiz.questions.Count){
                return CurrentQuiz.questions[CurrentQuestion].type;            
            } else {
                return "ended";
            }
            
        }
        // Lock synchronization object
		 private static object syncLock = new object();
		 
		 public static QuizHandler Instance
		 {
		 get
		 {
		 // Support multithreaded applications through
		 // 'Double checked locking' pattern which (once
		 // the instance exists) avoids locking each
		 // time the method is invoked
		 lock (syncLock)
		 {
		    if (QuizHandler.instance == null)
		         QuizHandler.instance = new QuizHandler();
		 
		     return QuizHandler.instance;
		 }
		 }
		 }
 
        
    }
}
