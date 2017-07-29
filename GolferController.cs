using Foundation;
using System;
using UIKit;

namespace HandicApp
{
    public partial class GolferController : UITabBarController
    {
        public static string name {get; set;}

        public GolferController (IntPtr handle) : base (handle)
        {
            //name = "austin";
            //DisplayCurrentHandicap.Text = name;
            
        }
    }
}