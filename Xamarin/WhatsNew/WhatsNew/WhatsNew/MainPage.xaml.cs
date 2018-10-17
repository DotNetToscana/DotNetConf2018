using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WhatsNew
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
        }

        protected override void OnAppearing()
        {
            CheckOrientation();
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            CheckOrientation();
        }

        public void CheckOrientation()
        {
            VisualStateManager.GoToState(MyEntry, (this.Width > this.Height) ? "Landscape" : "Portrait");
        }
    }
}
