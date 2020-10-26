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

namespace Learn_CSharp_UWP.Pages.Lab.Lab_25_Common_XAML_Controls_Part_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates
                .Select(p => p.Date.Day.ToString() + "/" + p.Date.Month.ToString() + "/" + p.Date.Year.ToString())
                .ToArray();

            calendarViewResult.Text = String.Join(", ", selectedDates);
        }

        private void flyoutButtonInner_Click(object sender, RoutedEventArgs e)
        {
            flyout.Hide();
        }

        private String[] data = new String[] { "C#", "C++", "PHP", "Java", "Python", };

        private void autoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            //var autoSuggestBox = (AutoSuggestBox)sender;

            var filtered = data.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();

            autoSuggestBox.ItemsSource = filtered;
        }
    }
}
