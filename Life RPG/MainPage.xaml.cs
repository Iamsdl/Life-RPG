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
using System.Linq.Expressions;
using System.Reflection;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Life_RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CharacterInstance character;

        public CharacterInstance Character
        {
            get => character; set
            {
                character = value;
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            //Character.
            Character = CharacterLibrary.Character.Instance;
        }

        private async void TxtCharacterName_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await ShowEditDialogFor(() => Character.Name, value => Character.Name = value);
        }
        private async void TxtCharacterDescription_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await ShowEditDialogFor(() => Character.Description, value => Character.Description = value);
        }
        private async System.Threading.Tasks.Task ShowEditDialogFor(Func<string> getter, Action<string> setter)
        {
            EditTextDialog dialog = new EditTextDialog(getter.Invoke());
            ContentDialogResult buttonClicked = await dialog.ShowAsync();
            switch (buttonClicked)
            {
                case ContentDialogResult.None:
                    break;
                case ContentDialogResult.Primary:
                    setter.Invoke(dialog.result);
                    //Bindings.Update();
                    break;
                case ContentDialogResult.Secondary:
                    break;
                default:
                    break;
            }

        }
        private async void ImgCharacterImage_Tapped(object sender, TappedRoutedEventArgs e)
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
