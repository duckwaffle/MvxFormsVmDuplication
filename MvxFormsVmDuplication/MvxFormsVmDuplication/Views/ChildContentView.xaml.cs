using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxFormsVmDuplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChildContentView
	{
		public ChildContentView()
		{
			InitializeComponent();
		}
	}
}