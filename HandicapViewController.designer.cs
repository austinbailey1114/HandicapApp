// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HandicApp
{
    [Register ("HandicapViewController")]
    partial class HandicapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CourseInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DateInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Enter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HandicapDisplayer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NewHandicapDisplayer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NewScorePrompt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ScoreInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WelcomeText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CourseInput != null) {
                CourseInput.Dispose ();
                CourseInput = null;
            }

            if (DateInput != null) {
                DateInput.Dispose ();
                DateInput = null;
            }

            if (Enter != null) {
                Enter.Dispose ();
                Enter = null;
            }

            if (HandicapDisplayer != null) {
                HandicapDisplayer.Dispose ();
                HandicapDisplayer = null;
            }

            if (NewHandicapDisplayer != null) {
                NewHandicapDisplayer.Dispose ();
                NewHandicapDisplayer = null;
            }

            if (NewScorePrompt != null) {
                NewScorePrompt.Dispose ();
                NewScorePrompt = null;
            }

            if (ScoreInput != null) {
                ScoreInput.Dispose ();
                ScoreInput = null;
            }

            if (WelcomeText != null) {
                WelcomeText.Dispose ();
                WelcomeText = null;
            }
        }
    }
}