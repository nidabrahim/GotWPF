using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GoTWPF.Entities;
using System.Net.Http;
using System.Net.Http.Headers;
using MahApps.Metro.Controls;

namespace GoTWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        House house;
        int i;
        List<House> houses;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if(((ListBox)sender).SelectedIndex == 0)
            { 
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
            }
        }

        /*
        public MainWindow()
        {  
            this.DataContext = this;
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }*/


        protected void MainWindow_Loaded(Object sender, RoutedEventArgs e)
        {
            houses = new List<House>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/house/GetAllHouses").Result;
            if (response.IsSuccessStatusCode)
            {
                houses = response.Content.ReadAsAsync<List<House>>().Result;
            }

            house = houses.ElementAt(0);
            i = houses.Count();
        }

        protected void LoadCharacter()
        {
            List<Character> characters = new List<Character>();
             
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/character/GetAllCharacters").Result;
            if (response.IsSuccessStatusCode)
            {
                characters = response.Content.ReadAsAsync<List<Character>>().Result;
            }

          
        }

        protected void LoadFight()
        {
            List<Fight> fights = new List<Fight>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/fight/GetAllFights").Result;
            if (response.IsSuccessStatusCode)
            {
                fights = response.Content.ReadAsAsync<List<Fight>>().Result;
            }

        }

        protected void LoadTerritory()
        {
            List<Territory> territories = new List<Territory>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/territory/GetAllTerritories").Result;
            if (response.IsSuccessStatusCode)
            {
                territories = response.Content.ReadAsAsync<List<Territory>>().Result;
            }

        }

    }
}
