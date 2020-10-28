using Learn_CSharp_UWP.Pages.Lab.Lab_49_UWP_SoundBoard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Learn_CSharp_UWP.Pages.Lab.Lab_49_UWP_SoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> Sounds;
        private List<MenuItem> MenuItems;
        private List<String> Suggestions;

        public MainPage()
        {
            this.InitializeComponent();

            Sounds = new ObservableCollection<Sound>();
            SoundManager.GetAllSounds(Sounds);

            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem { IconFile = "/Assets/SoundBoard/Icons/animals.png", Category = SoundCategory.Animals });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/SoundBoard/Icons/cartoon.png", Category = SoundCategory.Cartoons });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/SoundBoard/Icons/taunt.png", Category = SoundCategory.Taunts });
            MenuItems.Add(new MenuItem { IconFile = "/Assets/SoundBoard/Icons/warning.png", Category = SoundCategory.Warnings });

            BackButton.Visibility = Visibility.Collapsed;
        }

        private void HamburerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text))
            {
                goBack();
            }

            SoundManager.GetAllSounds(Sounds);
            Suggestions = Sounds.Where(p => p.Name.StartsWith(sender.Text)).Select(p => p.Name).ToList();
            SearchAutoSuggestBox.ItemsSource = Suggestions;
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SoundManager.GetSoundsByName(Sounds, sender.Text);
            CategoryTextBlock.Text = "Search Result: " + sender.Text;
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItem)e.ClickedItem;

            CategoryTextBlock.Text = menuItem.Category.ToString();
            SoundManager.GetSoundsByCategory(Sounds, menuItem.Category);

            BackButton.Visibility = Visibility.Visible;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Sound)e.ClickedItem;
            myMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile);
        }

        private async void SoundGridView_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                var items = await e.DataView.GetStorageItemsAsync();

                if (items.Any())
                {
                    var storageFile = (StorageFile)items[0];
                    var contentType = storageFile.ContentType;

                    StorageFolder folder = ApplicationData.Current.LocalFolder;

                    if (contentType == "audio/wav" || contentType == "audio/mpeg")
                    {
                        StorageFile newFile = await storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);
                        myMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read), contentType);
                        myMediaElement.Play();
                    }
                }
            }
        }

        private void SoundGridView_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;

            e.DragUIOverride.Caption = "drop to createa custom sound and title";
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;      
        }

        private void goBack()
        {
            SoundManager.GetAllSounds(Sounds);
            CategoryTextBlock.Text = "All Sounds";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }
    }
}
