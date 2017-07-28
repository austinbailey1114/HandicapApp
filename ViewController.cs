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
            HandicapViewer.Text = "Your handicap is: ";
            EnterButton.TouchUpInside += (object sender, EventArgs e) => {
                // Convert the phone number with text to a number
                // using PhoneTranslator.cs
                string s = ScoreInput.Text;
                ScoreInput.ResignFirstResponder();
                string[] scoreString = new string[20];
                scoreString[0] = s;
                double handicap = Golfer.calculateHandicap(scoreString);
                //score will actually come from a new calculation
                HandicapViewer.Text = "Your handicap is: " + handicap;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
