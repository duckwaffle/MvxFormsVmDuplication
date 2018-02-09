using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;

namespace MvxFormsVmDuplication.ViewModels
{
    public class ChildContentViewModel : MvxViewModel
    {
        private string someText = "Initial Text";

        public string SomeText
        {
            get => someText;
            set => SetProperty(ref someText, value);
        }
    }
}
