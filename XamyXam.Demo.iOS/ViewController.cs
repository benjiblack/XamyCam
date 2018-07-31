using System;
using XamyCam.iOS;
using UIKit;

namespace XamyXam.Demo.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            var cameraViewController = new CameraViewController();
            PresentViewController(cameraViewController, true, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
