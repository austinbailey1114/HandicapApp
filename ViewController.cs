using System;
using UIKit;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;

namespace HandicApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // will eventually calculate into actual handicap based on data
            HandicapViewer.Text = "Your handicap is: " + 1;
            EnterButton.TouchUpInside += (object sender, EventArgs e) => {
                // Convert the phone number with text to a number
                // using PhoneTranslator.cs
                string s = ScoreInput.Text;

                // Dismiss the keyboard if text field was tapped
                ScoreInput.ResignFirstResponder();
                string score = Golfer.testFunction(s);
                //score will actually come from a new calculation
                HandicapViewer.Text = "Your handicap is: " + score;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
