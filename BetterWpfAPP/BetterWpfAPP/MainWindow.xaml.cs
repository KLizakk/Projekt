using System;
using System.Data.SqlTypes;
using System.Net.Http;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BetterWpfAPP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Wyszukaj_GotFocus(object sender, RoutedEventArgs e)
        {

            Wprowadzanie.Text = "";
        }
        //private void Wyszukaj_LostFocs(object sender, RoutedEventArgs e)
        //{
        //    Wprowadzanie.Text = "straciłem focus";
        //}

        private async void PobierzDane_Click(object sender, RoutedEventArgs e)
        {

            string NazwaZawodnika;
            NazwaZawodnika = Wprowadzanie.Text;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-nba-v1.p.rapidapi.com/players?search={NazwaZawodnika}"),
                Headers =
    {
        { "X-RapidAPI-Key", "82e608ca0amshfb8be84d382c693p152ebejsn0ed3121d87c8" },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var Wczytywanie = JsonConvert.DeserializeObject<Root>(body);
                if (Wczytywanie.response == null )
                {
                    ErrorWindow errorWindow = new ErrorWindow();

                    errorWindow.Show();
                }


                else
                {
                    ImięZawodnika.Text = Wczytywanie?.response[0]?.firstname;
                    NazwiskoZawodnika.Text = Wczytywanie?.response[0]?.lastname;
                    WagaZawodnika.Text = Wczytywanie?.response[0]?.weight.kilograms;
                    WzrostZawodnika.Text = Wczytywanie?.response[0]?.height.meters;
                    IloscZawodnikow.Text = Wczytywanie?.response.Count.ToString();
                }


            }
        }
        private void CenterWindowOnScreen()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
        private void testokna_Click(object sender, RoutedEventArgs e)
        {
            ErrorWindow errorWindow = new ErrorWindow();
            errorWindow.Show();
            
        }
    }
}
