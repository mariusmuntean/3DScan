using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Forms.Presenter.Core;
using _3DScan.Utils;

namespace _3DScan
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            Mvx.RegisterType<IMvxFormsPageLoader, ViewLoader>();
            RegisterAppStart<ViewModels.HomeViewModel>();
        }
    }
}