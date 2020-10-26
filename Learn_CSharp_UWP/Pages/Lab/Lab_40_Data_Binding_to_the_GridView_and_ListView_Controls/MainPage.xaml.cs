using Learn_CSharp_UWP.Pages.Lab.Lab_40_Data_Binding_to_the_GridView_and_ListView_Controls.Models;
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

namespace Learn_CSharp_UWP.Pages.Lab.Lab_40_Data_Binding_to_the_GridView_and_ListView_Controls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;

        public MainPage()
        {
            this.InitializeComponent();
            Books = BookMamager.GetBooks();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;

            ResultTextBlock.Text = "You selected: " + book.Title;
        }
    }
}
