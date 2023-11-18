namespace Prakt8
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        string manDir = FileSystem.Current.AppDataDirectory;
        private void BornDP_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync();
            if(result != null) {
            var selectedPhotoStream = await result.OpenReadAsync();
                ImageView.Source = ImageSource.FromStream(() => selectedPhotoStream);
            }
        }
    }
}