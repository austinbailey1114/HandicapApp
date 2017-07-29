// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HandicApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EnterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ScoreInput { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EnterButton != null) {
                EnterButton.Dispose ();
                EnterButton = null;
            }

            if (ScoreInput != null) {
                ScoreInput.Dispose ();
                ScoreInput = null;
            }
        }
    }
}