using Bogus;
using NativeForms.Droid.Model;
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
    public partial class MySharedFormsPage : ContentPage
    {
        public MySharedFormsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var faker = new Faker<User>()
           .RuleFor(x => x.Name, (f, u) => f.Name.FirstName())
           .RuleFor(x => x.Surname, (f, u) => f.Name.LastName());

            var list = faker.Generate(15);
            People.ItemsSource = list;
        }
    }
}