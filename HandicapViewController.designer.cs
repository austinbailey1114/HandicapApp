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
        UIKit.UIButton EnterInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HandicapDisplayer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NewHandicapDisplayer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ScoreInput { get; set; }

        [Action ("UIButton2818_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2818_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EnterInput != null) {
                EnterInput.Dispose ();
                EnterInput = null;
            }

            if (HandicapDisplayer != null) {
                HandicapDisplayer.Dispose ();
                HandicapDisplayer = null;
            }

            if (NewHandicapDisplayer != null) {
                NewHandicapDisplayer.Dispose ();
                NewHandicapDisplayer = null;
            }

            if (ScoreInput != null) {
                ScoreInput.Dispose ();
                ScoreInput = null;
            }
        }
    }
}