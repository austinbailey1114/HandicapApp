using Foundation;
using System;
using UIKit;

namespace HandicApp
{
    public partial class SearchController : UIViewController
    {
        public SearchController (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string name = GolferController.name;
            search.TouchUpInside += (object sender, EventArgs e) => {
                string searchfield = SearchInput.Text;
                string result;
                if (searchfield.Contains("/")) {
                    result = Golfer.searchDate(searchfield, name + ".txt");
                }
                else {
                    result = Golfer.searchCourse(searchfield, name + ".txt");
                }
                TestLabel.Text = result;
            };
        }
    }
}