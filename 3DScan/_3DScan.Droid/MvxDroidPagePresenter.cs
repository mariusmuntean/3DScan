using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Forms.Presenter.Core;

namespace _3DScan.Droid
{
    public class MvxFormsDroidPagePresenter
        : MvxFormsPagePresenter
        , IMvxAndroidViewPresenter
    {
        public MvxFormsDroidPagePresenter()
        {
        }

        public MvxFormsDroidPagePresenter(MvxFormsApp mvxFormsApp)
            : base(mvxFormsApp)
        {
        }
    }
}