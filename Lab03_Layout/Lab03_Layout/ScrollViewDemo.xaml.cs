using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab03_Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScrollViewDemo : ContentPage
    {
        public ScrollViewDemo()
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(new BoxView { BackgroundColor = Color.Red, HeightRequest = 600, WidthRequest = 150 });
            stackLayout.Children.Add(new Entry());
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            Content = scrollView;
        }
    }
}