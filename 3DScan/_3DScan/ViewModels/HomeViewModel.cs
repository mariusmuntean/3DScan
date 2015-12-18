using Cirrious.MvvmCross.ViewModels;

namespace _3DScan.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
