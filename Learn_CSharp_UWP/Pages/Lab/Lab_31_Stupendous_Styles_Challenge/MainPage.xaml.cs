using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learn_CSharp_UWP.Pages.Lab.Lab_31_Stupendous_Styles_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            frameContent.Navigate(typeof(DonutPage));
        }

        private void btnDonut_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(typeof(DonutPage));
        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(typeof(CoffeePage));
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(typeof(SchedulePage));
        }

        private void btnComplete_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(typeof(CompletePage));
        }
    }
}
