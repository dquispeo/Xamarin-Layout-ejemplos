using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab03_Layout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new StackLayoutDemo();
            //MainPage = new AbsoluteLayoutDemo();
            //MainPage = new RelativeLayoutDemo();
            //MainPage = new GridDemo();
            //MainPage = new ScrollViewDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
