using System;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PhoneAppPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageEngasgo : Page
    {
        public PageEngasgo()
        {

            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
            {
                return;
            }

            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            ChamaJanela("Engasgo Infantil");
        }

        private void ChamaJanela(string ocorrencia)
        {
            this.Frame.Navigate(typeof(PageInstrucao), ocorrencia);
        }

        private void Ellipse_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Engasgo Infantil");
        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {
            ChamaJanela("Engasgo");
        }

        private void Ellipse_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Engasgo");
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Engasgo Infantil");
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Engasgo");
        }
        private void HardwareButtons_BackPressed1(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            try
            {
                //       PageInstrucao.mediaElement.Stop();
            }
            catch (Exception)
            {


            }



            if (frame == null)
            {
                return;
            }

            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }

        }
    }
}
