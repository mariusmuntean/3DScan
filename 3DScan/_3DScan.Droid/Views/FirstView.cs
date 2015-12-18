using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace _3DScan.Droid.Views
{
    [Activity(Label = "View for HomeViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}