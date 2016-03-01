using System;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PhoneAppPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool firstRun = true;


        public MainPage()
        {           
            if(firstRun)
            {
                MostraPopup();
                firstRun = false;
            }
            HardwareButtons.BackPressed += HardwareButtons_BackPressed1;

            this.InitializeComponent();           
            this.NavigationCacheMode = NavigationCacheMode.Required;
            AppPi.AdicionarOcorrencia();
            var displayRequest = new Windows.System.Display.DisplayRequest();
            displayRequest.RequestActive();
            VerificaSwitch();
        }
        
        public async void  MostraPopup()
        {      
            MessageDialog msgbox = new MessageDialog("ANTES DE TUDO, CHAME A EMERGÊNCIA !!!");
            msgbox.Commands.Add(new UICommand("Ligar",
        new UICommandInvokedHandler(this.CommandInvokedHandler)));
            msgbox.Commands.Add(new UICommand("Fechar"));

                //Calling the Show method of MessageDialog class  
                //which will show the MessageBox  
                await msgbox.ShowAsync();  
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI("192", "SAMU");
            
        }


        private void Ellipse_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
          //  var stream = await synth.SynthesizeTextToStreamAsync("Cléverson Specht");

           // mediaElement.SetSource(stream, stream.ContentType);
            //mediaElement.Play();
        }

        private void EL_Centro_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }



        private void ElipseAfogamento(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Afogamento";

            ChamaJanela(ocorrencia);
        }

        private void ElipseParadaCardiaca(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Parada Cardíaca";

            ChamaJanela(ocorrencia);
        }

        private void ElipseQueimadura(object sender, TappedRoutedEventArgs e)
        {
                this.Frame.Navigate(typeof(PageQueimadura));
                   }

        private void ElipseEpilepsia(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Epilepsia";

           
                ChamaJanela(ocorrencia);
          
        }

        private void ElipseCorte(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Hemorragia"; //mudar sapoha aki, chamar pagina de escolha de ocorrencia COrte/Hemorragia

            ChamaJanela(ocorrencia);
        }

        private void ElipseEngasgo(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PageEngasgo));
        }

        private void ElipseQuedas(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Quedas";

            ChamaJanela(ocorrencia);

        }

        private void ElipseAcidenteTransito(object sender, TappedRoutedEventArgs e)
        {
            string ocorrencia = "Acidentes de Trânsito";

            ChamaJanela(ocorrencia);

        }

        private void ChamaJanela(string ocorrencia)
        {
            this.Frame.Navigate(typeof(PageInstrucao), ocorrencia);
        }

        private void MostraNome(string ocorrencia)
        {
            txtOcorrencia.Text = ocorrencia;
        }

        private void Ellipse_Holding(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Queimadura";
            MostraNome(ocorrencia);
        }

        private void Ellipse_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            MostraNome("");
        }

        private void Ellipse_Holding_1(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Epilepsia";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_2(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Cortes e Hemorragia";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_3(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Engasgo";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_4(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Quedas";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_5(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Afogamento";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_6(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Parada Cardíaca";
            MostraNome(ocorrencia);
        }

        private void Ellipse_Holding_7(object sender, HoldingRoutedEventArgs e)
        {
            string ocorrencia = "Acidentes de Trânsito";
            MostraNome(ocorrencia);
        }

        private void HardwareButtons_BackPressed1(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
                       

            if (frame.CurrentSourcePageType == Type.GetType("PhoneAppPI.MainPage"))
            {
                Application.Current.Exit();
                return;
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

        private void VerificaSwitch()
        {
   
                PageInstrucao.bContinuo = switchContinuo.IsOn;
      
            
        }
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            VerificaSwitch();
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI("192", "SAMU");
        }
    }
}
////