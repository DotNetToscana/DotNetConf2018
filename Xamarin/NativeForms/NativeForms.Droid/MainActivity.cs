using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace NativeForms.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.standardButton);
            fab.Click += FabOnClick;

            FloatingActionButton fabPeople = FindViewById<FloatingActionButton>(Resource.Id.peopleButton);
            fabPeople.Click += FabPeople_Click;
        }

        private void FabPeople_Click(object sender, EventArgs e)
        {
            var formsPage = new MySharedFormsPage().CreateFragment(this);
            FragmentManager.BeginTransaction().Replace(Resource.Id.pageContent, formsPage).Commit();
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            var formsPage = new MyFormsPage().CreateFragment(this);
            FragmentManager.BeginTransaction().Replace(Resource.Id.pageContent, formsPage).Commit();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
	}
}

