using Xamarin.Forms;

namespace ImageSourceTest
{
	public class App : Application
	{
		public App ()
		{
            var image = new Image() { Aspect = Aspect.AspectFit, WidthRequest = 200, HeightRequest = 200 };
		    image.Source = ImageSource.FromFile("/storage/emulated/0/Pictures/fc3c6039-9d29-4d36-ac65-34e834781ecb.jpg"); // put your image path here

            MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
                        new Label { Text = "Image:"},
						image
					}
				}
			};
		}

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
