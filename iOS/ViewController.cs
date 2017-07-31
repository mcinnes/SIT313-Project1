using System;
using Newtonsoft.Json;
using UIKit;
using System.IO;
using System.Collections.Generic;

namespace JSONTest.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;
        QuizHandler qHandle;
        Question testQu;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.SetTitle("fuck", UIControlState.Normal);
            Button.TouchUpInside += delegate
            {
                var title = string.Format("{0} clicks!", count++);
                Button.SetTitle(title, UIControlState.Normal);
            };
	        JSONTest();            
        }
        
        public void JSONTest(){
        
        //Quiz q = JsonConvert.DeserializeObject<Quiz>(File.ReadAllText(@"quizzes_sample.json"));
       
        
	    var observation = JsonConvert.DeserializeObject<List<Quiz>>(File.ReadAllText(@"quizzes_sample.json"));
	        
        Console.WriteLine(observation.Count.ToString());

        foreach (Quiz q in observation){
            Console.WriteLine(q.title);
            Console.WriteLine(q.questions.Count.ToString());
                foreach (Question qi in q.questions){
                  Console.WriteLine(qi.text);
                }
                
        }
        
            Quiz qu = observation[0];
            testQu = qu.questions[4];
            Console.WriteLine(testQu.id);
            App.quizHandler.setQuiz(observation[0]);
                            
           // PerformSegue("sliding", Self);
           
	    }

        partial void changeView(UIButton sender)
        {
            throw new NotImplementedException();
        }
        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "sliding")
            {
                var itvc = (SlidingQuestionViewController)segue.DestinationViewController;
                if (itvc != null)
                {
                   // itvc = new SlidingQuestionViewController(testQu);
                   //itvc.setQuestion(testQu);
                }
            }
            
        }
        
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.        
        }
        #region Application Access
	    public static AppDelegate App {
	        get { return (AppDelegate)UIApplication.SharedApplication.Delegate; }
	    }
        #endregion
    }
}
