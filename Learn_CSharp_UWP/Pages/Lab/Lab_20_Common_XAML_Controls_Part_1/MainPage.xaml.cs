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

namespace Learn_CSharp_UWP.Pages.Lab.Lab_20_Common_XAML_Controls_Part_1
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

        private void checkBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            checkBoxResult.Text = checkBox.IsChecked.ToString();
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            radioButtonResult.Text = (bool)yesRadioButton.IsChecked ? "Yes" : "No";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxResult == null) 
            {
                return;
            }

            var comboBox = (ComboBox)sender;
            var item = (ComboBoxItem)comboBox.SelectedItem;
            comboBoxResult.Text = item.Content.ToString();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = listBox.Items.Cast<ListBoxItem>()
                .Where(p => p.IsSelected)
                .Select(t => t.Content.ToString())
                .ToArray();

            listBoxResult.Text = String.Join(", ", selectedItems);
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            toggleButtonResult.Text = toggleButton.IsChecked.ToString();
        }
    }
}
