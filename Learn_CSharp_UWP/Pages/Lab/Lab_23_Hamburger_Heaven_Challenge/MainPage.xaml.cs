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

namespace Learn_CSharp_UWP.Pages.Lab.Lab_23_Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Home_ListBoxItem.IsSelected = true;
            lblTitle.Text = "Home";
            btnBack.Visibility = Visibility.Collapsed;
            frame_Content.Navigate(typeof(Pages.Lab.Lab_23_Hamburger_Heaven_Challenge.Home));
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            SplitViewMenu.IsPaneOpen = !SplitViewMenu.IsPaneOpen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (frame_Content.CanGoBack)
            {
                frame_Content.GoBack();
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var itemName = listBoxMenu.Items.Cast<ListBoxItem>()
                .Where(t => t.IsSelected)
                .Select(p => p.Name.ToString())
                .First()
                .Replace("_ListBoxItem", "");

            lblTitle.Text = itemName;

            //Cách 1
            //frame_Content.Navigate(typeof(Pages.Lab.Lab_23_Hamburger_Heaven_Challenge.Favourites));

            //Cách 2
            var fully_qualified_class_name_string = "Learn_CSharp_UWP.Pages.Lab.Lab_23_Hamburger_Heaven_Challenge." + itemName;
            Type type = Type.GetType(fully_qualified_class_name_string);
            if (type != null)
            {
                frame_Content.Navigate(type);
            } else
            {
                lblTitle.Text = "Lỗi điều hướng, Trang này không tồn tại";
            }

            if (itemName != "Home")
            {
                btnBack.Visibility = Visibility.Visible;
            } else
            {
                btnBack.Visibility = Visibility.Collapsed;
            }
        }
    }
}
