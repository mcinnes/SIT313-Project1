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

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
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
                foreach (Question qu in q.questions){
                  Console.WriteLine(qu.text);
                }
        }
         
    

	    }

        partial void changeView(UIButton sender)
        {
            throw new NotImplementedException();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.        
        }
    }
}
