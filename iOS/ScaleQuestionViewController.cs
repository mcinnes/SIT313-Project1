using System;

using UIKit;

namespace JSONTest.iOS
{
    public partial class ScaleQuestionViewController : UIViewController
    {
        public ScaleQuestionViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
                        Console.WriteLine(this.NavigationController.ViewControllers);
            for (int i = 0x0; i <= 0x1b3; i++) {
             // Do stuff with i

    // Converts the integer to hex, if that's what you wanted.
                string str = i.ToString("X");
            }
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

