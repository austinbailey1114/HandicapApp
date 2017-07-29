using Foundation;
using System;
using UIKit;
using System.IO;

namespace HandicApp
{
    public partial class HandicapViewController : UIViewController
    {
        public HandicapViewController (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            
            base.ViewDidLoad();
            // will eventually calculate into actual handicap based on data
            string name = GolferController.name;
            if (File.Exists(name)) {
                Golfer currentUser  = new Golfer(name);
                double s = currentUser.handicap;
                HandicapDisplayer.Text = "Your handicap is: " + s;
            }
            else {
                HandicapDisplayer.Text = "You need to enter more scores!";
            }

            EnterInput.TouchUpInside += (object sender, EventArgs e) => {
                string s = ScoreInput.Text;
                ScoreInput.ResignFirstResponder();
                string[] scoreString = new string[20];
                scoreString[0] = s;
                double newHandicap = Golfer.calculateHandicap(scoreString);
                NewHandicapDisplayer.Text = "Your new handicap is: " + newHandicap;
            };


           




        }
    }
}