using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Forms.Presenter.Core;

namespace _3DScan.Utils
{
    public class ViewLoader : MvxFormsPageLoader
    {
        protected override string GetPageName()
        {
            var name = base.GetPageName();

            return name.Replace("Page", "View");
        }
    }
}
