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
using GoTWPF.Entities;

namespace GoTWPF
{
    /// <summary>
    /// Logique d'interaction pour DataCharacters.xaml
    /// </summary>
    public partial class DataCharacters : Window
    {

        public List<Character> objList = new List<Character>();

        public DataCharacters()
        {
            InitializeComponent();

            LoadCharacters();
            
            dataNormalGrid.ItemsSource = objList;

        }

        private void LoadCharacters()
        {
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/character/GetAllCharacters").Result;
            if (response.IsSuccessStatusCode)
            {
                objList = response.Content.ReadAsAsync<List<Character>>().Result;
            }
        }

        private void LoadStubCharacters()
        {
            objList.Add(new Character("Youssef", "NIDABRAHIM", 17, 20, 18));
            objList.Add(new Character("Youssef", "NIDABRAHIM", 17, 20, 18));
            objList.Add(new Character("Youssef", "NIDABRAHIM", 17, 20, 18));
            objList.Add(new Character("Youssef", "NIDABRAHIM", 17, 20, 18));
            objList.Add(new Character("Youssef", "NIDABRAHIM", 17, 20, 18));
        }
    }
}
