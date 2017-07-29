using Foundation;
using System;
using UIKit;
using System.IO;
using System.Collections.Generic;

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
            WelcomeText.Text = "Welcome, "+name+"!";
            Golfer currentUser  = new Golfer(name + ".txt");
            if (currentUser.handicap != -100) {
                double s = currentUser.handicap;
                HandicapDisplayer.Text = "Your handicap is: " + s;
            }
            else {
                //StreamWriter sw = File.CreateText(name);
                //sw.WriteLine(120);
                //sw.Close();
                //Golfer newUser = new Golfer(name);
                HandicapDisplayer.Text = "You are a new user";
                NewScorePrompt.Text = "Enter your first round below";
                File.CreateText(name + ".txt");
            }


            Enter.TouchUpInside += (object sender, EventArgs e) => {
                string score = ScoreInput.Text;
                ScoreInput.ResignFirstResponder();
                string date = DateInput.Text;
                DateInput.ResignFirstResponder();
                string course = CourseInput.Text;
                CourseInput.ResignFirstResponder();
                List<string[]> newScore = new List<string[]>();
                string data = score + "," + date + "," + course;
                string[] scoreString = data.Split(',');
                newScore.Add(scoreString);
                string newHandicap = Golfer.updateScores(newScore, name + ".txt");
                NewHandicapDisplayer.Text = "Your updated handicap is: " + newHandicap;


            };
        }
    }
}