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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using GoTWPF.View;

namespace GoTWPF
{
    /// <summary>
    /// Logique d'interaction pour MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : MetroWindow
    {

        List<clsTiles> objTileList = new List<clsTiles>();

        public MenuPrincipal()
        {
            InitializeComponent();

            var ScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;

            objTileList.Add(new clsTiles { Title = "Houses", Color = "Red", Type = "Form", Icon = "images/houses.png" });
            objTileList.Add(new clsTiles { Title = "Characters", Color = "#D2691E", Type = "Form", Icon = "images/characters.jpg" });
            objTileList.Add(new clsTiles { Title = "Fights", Color = "#1E90FF", Type = "Form", Icon = "images/fights.png" });
            objTileList.Add(new clsTiles { Title = "Territories", Color = "Green", Type = "Form", Icon = "images/territories.png" });
           
            ItemsTiles.ItemsSource = objTileList;
            ItemsTiles.Width = ScreenWidth + 100;
        }

        public string SelectedTile;
        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            var Sender = (MahApps.Metro.Controls.Tile)sender;
            SelectedTile = Sender.Title;
            if (SelectedTile == "Houses")
            {
                /*Data data = new Data();
                data.ShowDialog();*/

                Viewer houseView = new Viewer();
                houseView.ShowDialog();

            }
            else
            {
                if(SelectedTile == "Characters")
                {
                    /*DataCharacters dataCharacters = new DataCharacters();
                    dataCharacters.ShowDialog();*/
                    CharacterViewer charactersView = new CharacterViewer();
                    charactersView.ShowDialog();
                }
            }
        }
       
    }

    public class clsTiles
    {
        public string Title { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
    }
}

