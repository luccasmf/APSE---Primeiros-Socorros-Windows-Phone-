using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PhoneAppPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageInstrucao : Page
    {


        SpeechSynthesizer synth;
        private Ocorrencia o;
        private int controladorPasso = 0;
        public static bool bContinuo = false;

        public PageInstrucao()
        {
            HardwareButtons.BackPressed += HardwareButtons_BackPressed1;

            this.InitializeComponent();

            mediaElement.Volume = 10;
            synth = new SpeechSynthesizer();
            synth.Voice = SpeechSynthesizer.AllVoices.First(i => i.Language == "pt-BR" && i.Gender == VoiceGender.Female);

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            o = AppPi.carregarOcorrencia(e.Parameter.ToString());
            MudaImagem(e.Parameter.ToString());

            textBlockInstrucao.Text = o.passos[controladorPasso];

        }

        private void MudaImagem(string ocorrencia)
        {
            //{ms-appx:/Assets/Untitled-1.png}
            BitmapImage image = new BitmapImage();
            switch (ocorrencia)
            {
                case "Acidentes de Trânsito":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonAcidenteCarro.png"));
                    break;
                case "Parada Cardíaca":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonAtaqueCardiaco.png"));
                    break;
                case "Afogamento":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonAfogamento.png"));
                    break;
                case "Quedas":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonQueda.png"));
                    break;
                case "Hemorragia":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonCortes.png"));
                    break;
                case "Epilepsia":
                    image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonEplepsia.png"));
                    break;
                default:
                    if (ocorrencia.Contains("Engasgo"))
                    {
                        image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonEngasgo.png"));
                    }
                    else if (ocorrencia.Contains("Queimadura"))
                    {
                        image = new BitmapImage(new Uri("ms-appx:/Assets/ButtonQueimadura.png"));
                    }
                    else
                    {
                        image = new BitmapImage(new Uri("ms-appx:/Assets/btn_vermelho.png"));
                    }
                    break;
            }


            ImgOcorrencia.Source = image;
        }



        private void LVI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            AtualizarPasso();
        }

        public async void AtualizarPasso()
        {
            textBlockInstrucao.Text = o.passos[controladorPasso];
            var stream = await synth.SynthesizeTextToStreamAsync(textBlockInstrucao.Text);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void imageAnterior_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (controladorPasso > 0)
            {
                controladorPasso--;
                AtualizarPasso();
            }
        }

        private void imageProxima_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (controladorPasso < o.passos.Count() - 1)
            {
                controladorPasso++;
                AtualizarPasso();
            }
        }

        private void imageResetar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            textBlockInstrucao.Text = "";
            mediaElement.Stop();
            controladorPasso = 0;
        }

        private void imageParar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mediaElement.Stop();

        }

        private void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {

        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var i = Img.Source;
            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI("192", "SAMU");
        }

        private async void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            if (bContinuo)
                if (controladorPasso < o.passos.Count() - 1)
                {
                    controladorPasso++;
                    AtualizarPasso();

                }

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
