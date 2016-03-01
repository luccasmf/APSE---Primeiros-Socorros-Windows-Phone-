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
    public sealed partial class PageQueimadura : Page
    {
        public PageQueimadura()
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

        private void Eli_1Grau_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura1");
           
        }

        private void Ellipse_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura2");
        }

        private void Ellipse_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura3");
        }

        private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura1");
        }

        private void Rectangle_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura2");
        }

        private void Rectangle_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            ChamaJanela("Queimadura3");
        }

        private void ChamaJanela(string ocorrencia)
        {
            this.Frame.Navigate(typeof(PageInstrucao), ocorrencia);
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
