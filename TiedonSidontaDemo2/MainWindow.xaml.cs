using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //for Observableitems
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
using JAMK.ICT;

namespace TiedonSidontaDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//Koska usempi metodi=tapahtumakäsiuttleijä tulee käytäämään näitä muuttujija
        //määritellään luokantasolle 
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        private void IniMyStuff()
        {
            //tänne kootusti omien controllien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Star Wars");
            muuvit.Add("Terminator");
            muuvit.Add("sda");
            cmbMovies.ItemsSource = muuvit;
            //Haetaan SMliiga joukkueet
            liiga = new JAMK.ICT.HockeyLeague(); 
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään Stackpanelin DataContext
            //DEmo1: Datacontextina on Olio
            //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("KeuPa", "Keuruu");
            //spRight.DataContext = tiimi;

            //Demo2: Kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }
        private void btnBind_Click2(object sender, RoutedEventArgs e)
        {

        }
        private void btnBind_Click3(object sender, RoutedEventArgs e)
        {
            //TOdo kotona
        }
    }
}
