using System;
using UIKit;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using Foundation;

namespace HandicApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            //leave blank
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // will eventually calculate into actual handicap based on data
            HandicapViewer.Text = "Your handicap is: ";
            EnterButton.TouchUpInside += (object sender, EventArgs e) => {
                string s = ScoreInput.Text;
                ScoreInput.ResignFirstResponder();
                string[] scoreString = new string[20];
                scoreString[0] = s;
                StreamWriter sw = File.CreateText("austin.txt");
                sw.WriteLine(scoreString[0]);
                sw.Close();
                Golfer austin = new Golfer("austin.txt");
                double handicap = austin.handicap;
                HandicapViewer.Text = "Your handicap is: " + handicap;
            };





        }
        public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue (segue, sender);

            // set the View Controller that’s powering the screen we’re
            // transitioning to

            var DataController = segue.DestinationViewController as GolferController;

            //set the Table View Controller’s list of phone numbers to the
            // list of dialed phone numbers

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}
