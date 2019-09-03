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
using Life_RPG.Dialogs;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media.Imaging;
using CharacterLibrary;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Life_RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Character character;
        public MainPage()
        {
            character = new Character();
            this.InitializeComponent();
        }

        private async System.Threading.Tasks.Task TxtCharacterDescription_TappedAsync(object sender, TappedRoutedEventArgs e)
        {
            EditTextDialog dialog = new EditTextDialog(txtCharacterDescription.Text);
            ContentDialogResult buttonClicked = await dialog.ShowAsync();
            switch (buttonClicked)
            {
                case ContentDialogResult.None:
                    break;
                case ContentDialogResult.Primary:
                    txtCharacterDescription.Text = dialog.result;
                    character.Description = dialog.result;
                    break;
                case ContentDialogResult.Secondary:
                    break;
                default:
                    break;
            }
        }

        private async System.Threading.Tasks.Task TxtCharacterName_TappedAsync(object sender, TappedRoutedEventArgs e)
        {
            EditTextDialog dialog = new EditTextDialog(txtCharacterName.Text);
            ContentDialogResult buttonClicked = await dialog.ShowAsync();
            switch (buttonClicked)
            {
                case ContentDialogResult.None:
                    break;
                case ContentDialogResult.Primary:
                    txtCharacterName.Text = dialog.result;
                    character.Name = dialog.result;
                    break;
                case ContentDialogResult.Secondary:
                    break;
                default:
                    break;
            }
        }

        private async System.Threading.Tasks.Task ImgCharacterImage_TappedAsync(object sender, TappedRoutedEventArgs e)
        {
            FileOpenPicker dialog = new FileOpenPicker();
            dialog.ViewMode = PickerViewMode.Thumbnail;
            dialog.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            dialog.FileTypeFilter.Add(".jpg");
            dialog.FileTypeFilter.Add(".jpeg");
            dialog.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file = await dialog.PickSingleFileAsync("*");
            if (file != null)
            {
                imgCharacterImage.Source = new BitmapImage(new Uri(file.Path));
            }
        }
    }
}
