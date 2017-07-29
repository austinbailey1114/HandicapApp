using System;
using UIKit;
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
            EnterButton.TouchUpInside += (object sender, EventArgs e) => {
                string username = ScoreInput.Text;
                ScoreInput.ResignFirstResponder();
                GolferController.name = username;
            };





        }
        public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue (segue, sender);
            var golferController = segue.DestinationViewController as GolferController;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}
