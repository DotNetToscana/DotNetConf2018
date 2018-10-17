using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NativeForms.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFormsPage : ContentPage
    {
        public MyFormsPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Result.Text = "The Xamarin Forms button has been clicked!";
        }
    }
}