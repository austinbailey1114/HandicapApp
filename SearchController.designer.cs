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
    [Register ("SearchController")]
    partial class SearchController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton search { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SearchInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TestLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (search != null) {
                search.Dispose ();
                search = null;
            }

            if (SearchInput != null) {
                SearchInput.Dispose ();
                SearchInput = null;
            }

            if (TestLabel != null) {
                TestLabel.Dispose ();
                TestLabel = null;
            }
        }
    }
}