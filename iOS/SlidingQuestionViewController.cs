using Foundation;
using System;
using UIKit;

namespace JSONTest.iOS
{
    public partial class SlidingQuestionViewController : UIViewController
    {
        public SlidingQuestionViewController (IntPtr handle) : base (handle)
        {
        }

        partial void sliderChanged(UISlider sender)
        {
            answerLabel.Text = sliderControl.Value.ToString();
        }
    }
}