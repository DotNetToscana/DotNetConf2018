using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexLayoutSample.UserControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCustomImage : ContentView
	{
		public MyCustomImage ()
		{
			InitializeComponent ();
		}
	}
}