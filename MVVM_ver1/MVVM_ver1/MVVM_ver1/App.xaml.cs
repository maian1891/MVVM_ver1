using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVVM_ver1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application
            var content = new ContentPage
            {
                Title = "MVVM_ver1",
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

    }
}
