﻿using System;

using UIKit;

namespace JSONTest.iOS
{
    public partial class TextAreaQuestionViewController : UIViewController
    {
        
        private Question Question;

        public TextAreaQuestionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            setQuestion();
            NavigationItem.Title = "Question " + Question.id;
            questionLabel.Text = Question.text;
    
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        
         //Shared accross all Question ViewControllers
        public void setQuestion ()
        {
            Question = App.quizHandler.GetQuestion();
        }
        
        partial void SubmitQuestion(UIButton sender)
        {
            
            String nextQuestionType = App.quizHandler.NextQuestion();

            if (nextQuestionType != "ended"){
                //PerformSegue(nextQuestionType, this);

                this.NavigationController.PerformSegue(nextQuestionType, this);
                
            } else {
                PerformSegue("quizEnded", this);
            }
        }

        #region Application Access
        public static AppDelegate App {
            get { return (AppDelegate)UIApplication.SharedApplication.Delegate; }
        }
    #endregion
    }
}

