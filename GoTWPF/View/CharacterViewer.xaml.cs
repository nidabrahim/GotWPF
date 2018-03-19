using GoTWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GoTWPF.View
{
    /// <summary>
    /// Logique d'interaction pour CharacterViewer.xaml
    /// </summary>
    public partial class CharacterViewer : Window
    {
        private List<CharacterViewModel> listCharacterViewModel;

        public CharacterViewer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCharacters();
            ucCharacters.dataNormalGrid.ItemsSource = listCharacterViewModel;
        }

        private void LoadCharacters()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/character/GetAllCharacters").Result;
            if (response.IsSuccessStatusCode)
            {
                listCharacterViewModel = response.Content.ReadAsAsync<List<CharacterViewModel>>().Result;
            }
        }
    }
}
