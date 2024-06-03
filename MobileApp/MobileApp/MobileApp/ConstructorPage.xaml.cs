using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

using System.IO;

using Xamarin.Forms.Xaml;
using Plugin.Media.Abstractions;
using Plugin.Media;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConstructorPage : ContentPage
    {
        public ConstructorPage()
        {
            InitializeComponent();
        }
        private async void OnAddFabricButtonClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Добавить ткань", "Отмена", null, "Сделать фото", "Выбрать из галереи");
            if (action == "Выбрать из галереи")
            {
                var photo = await TakePhotoAsync();
                // Далее вы можете использовать выбранное фото
            }
            else if (action == "Сделать фото")
            {
                var photo = await PickPhotoAsync();
                // Далее вы можете использовать выбранное фото
            }
        }
        private async Task<MediaFile> ConvertToMediaFile(FileResult fileResult)
        {
            if (fileResult == null)
                return null;

            byte[] data;

            using (var stream = await fileResult.OpenReadAsync())
            {
                data = new byte[stream.Length];
                await stream.ReadAsync(data, 0, (int)stream.Length);
            }

            var mediaFile = new MediaFile(fileResult.FullPath, () => new MemoryStream(data));
            return mediaFile;
        }

        private async Task<MediaFile> TakePhotoAsync()
        {
            try
            {
                var photo = await CrossMedia.Current.PickPhotoAsync();
                return photo;
            }
            catch (FeatureNotSupportedException)
            {
                // Камера недоступна на устройстве
                // Обработайте соответствующим образом
            }
            catch (PermissionException)
            {
                // Недостаточно прав для доступа к камере
                // Обработайте соответствующим образом
            }
            catch (Exception)
            {
                // Произошла другая ошибка
                // Обработайте соответствующим образом
            }

            return null;
        }

        private async Task<MediaFile> PickPhotoAsync()
        {
            try
            {
                var fileResult = await MediaPicker.PickPhotoAsync();
                var mediaFile = await ConvertToMediaFile(fileResult);
                return mediaFile;
            }
            catch (PermissionException)
            {
                // Недостаточно прав для доступа к галерее
                // Обработайте соответствующим образом
            }
            catch (Exception)
            {
                // Произошла другая ошибка
                // Обработайте соответствующим образом
            }

            return null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}