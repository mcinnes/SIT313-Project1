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
        public SlidingQuestionViewController (decimal start, decimal end, decimal increment){
            
        }
        partial void sliderChanged(UISlider sender)
        {
            answerLabel.Text = sliderControl.Value.ToString();
        }
    }
}