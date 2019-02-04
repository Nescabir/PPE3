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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Diagnostics; // Pour l'objet debug
using System.Globalization;
using Xceed.Wpf.Toolkit;

namespace ClientTechEGC
{
    class Obstacle
    {
        public int? id { get; set; }
        public string nomObstacle { get; set; }
    }
    class Partie
    {
        public int? ID { get; set; }
        public string Pseudo { get; set; }
        public DateTime? Heure { get; set; }
    }

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JoueurApi joueurApi = new JoueurApi();
        PartiesApi partiesApi = new PartiesApi();
        SallesApi sallesApi = new SallesApi();
        AssociationpartieobstaclespositionApi associationpartieobstaclespositionApi = new AssociationpartieobstaclespositionApi();
        ObstaclesApi obstaclesApi = new ObstaclesApi();
        
        public MainWindow()
        {
            InitializeComponent();

            MainWindowTech.Title = "Logiciel Technicien - EGC";
            MainWindowTech.WindowStyle = WindowStyle.SingleBorderWindow;
            
            Configuration.Default.Username = "technicien";
            Configuration.Default.Password = "technicien2018*";
            Configuration.Default.BasePath = "http://193.70.0.15:8080";

            //Partie connexion
            //while (joueurApi.GetJoueurCollection(1) == null)
            //{
            //    Connection();
            //}

            //Met les datePicker sur la date d'aujourd'hui 
            reservationsDatePicker.SelectedDate = DateTime.Now;
            reserverDatePicker.SelectedDate = DateTime.Now;

            //Affichage des joueurs
            AffichageJoueurs();
            
        }

        private void MainWindowTech_Loaded(object sender, RoutedEventArgs e)
        {

            //Affichage obstacles disponibles
            AffichageObstaclesDispo();

            //Affichage salles pour reserver
            List<Salles> sallesDispo = sallesApi.GetSallesCollection();
            foreach (Salles salle in sallesDispo)
            {
                sallesComboBox.Items.Add(salle.Nomsalle);
            }

            //Affichage des parties
            AffichagePartie();

            //PopUpLogin();


        }

        private void PopUpLogin()
        {
            LoginWindow loginWindow = new LoginWindow
            {
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen,
                Owner = this
            };
            loginWindow.ShowDialog();
        }

        private void Connection()
        {

        }

        private void ReservationsDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            AffichagePartie();
        }

        private void PartiesListview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Partie partieSelectList = (Partie)partiesListview.SelectedItem;
            Parties partieSelect = partiesApi.GetPartiesItem(Convert.ToString(partieSelectList.ID));
            Salles salleSelect = sallesApi.GetSallesItem(partieSelect.Idsalle.Substring(8,1));

            nbJoueursReservationTextbox.Text = Convert.ToString(partieSelect.Nombrejoueur);
            nomSalleReservationTextbox.Text = salleSelect.Nomsalle;

            List<Obstacles> obstaclesSelect = obstaclesApi.GetbyPartie(partieSelect.Idpartie);
            foreach (Obstacles obstacle in obstaclesSelect)
            {
                obstaclesListBox.Items.Add(obstacle.Typeobstacle);
            }
            
        }

        private void ObstaclesAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (obstaclesDispoListView.SelectedIndex != -1)
            {
                Obstacle obstacleSelect = (Obstacle)obstaclesDispoListView.SelectedValue;
                ObstaclesUtilListView.Items.Add(obstaclesDispoListView.SelectedValue);
                obstaclesDispoListView.Items.Remove(obstaclesDispoListView.SelectedValue);
            }
            else
            {
                MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Vous devez selectionner une obstacle !", "Erreur");
            }
            
        }

        private void ObstaclesRetirer_Click(object sender, RoutedEventArgs e)
        {
            if (ObstaclesUtilListView.SelectedIndex != -1)
            {
                Obstacle obstacleSelect = (Obstacle)ObstaclesUtilListView.SelectedValue;
                obstaclesDispoListView.Items.Add(ObstaclesUtilListView.SelectedValue);
                ObstaclesUtilListView.Items.Remove(ObstaclesUtilListView.SelectedValue);
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (pseudoReserverCombobox.SelectedIndex != -1 && nbJoueursReserverTextbox.Text != "" && heureReserverTextbox.Text != "" && sallesComboBox.SelectedIndex != -1 && ObstaclesUtilListView.Items.Count != 0)
            {
                int hour, minutes;
                DateTime dateDatePicker = (DateTime)reserverDatePicker.SelectedDate;
                hour = Int32.Parse(heureReserverTextbox.Text.Substring(0, 2));
                minutes = Int32.Parse(heureReserverTextbox.Text.Substring(3, 2));
                Joueur joueurReserv = joueurApi.GetByPseudo(pseudoReserverCombobox.Text);
                DateTime dateSelect = new DateTime(dateDatePicker.Year, dateDatePicker.Month, dateDatePicker.Day, hour, minutes, 0);

                //Partie à poster
                Parties nouvellePartie = new Parties() { Idsalle = "/salles/" + (sallesComboBox.SelectedIndex + 1), Dateheuredebutpartie = dateSelect, Dateheurefinpartie = dateSelect.AddHours(1), Idjoueurpartie = "/joueurs/" + Convert.ToString(joueurReserv.Idjoueur), Nombrejoueur = Convert.ToInt32(nbJoueursReserverTextbox.Text), Nombreobstacles = ObstaclesUtilListView.Items.Count};

                if (ObstaclesUtilListView.Items.Count <= 8)
                {
                    try
                    {
                        //Envoi partie
                        partiesApi.PostPartiesCollection(nouvellePartie);

                        //RAZ
                        ObstaclesUtilListView.Items.Clear();
                        obstaclesDispoListView.Items.Clear();
                        heureReserverTextbox.Text = "";
                        nbJoueursReserverTextbox.Text = "";
                        pseudoReserverCombobox.SelectedIndex = -1;
                        sallesComboBox.SelectedIndex = -1;

                    }
                    catch (Exception ex)
                    {
                        Debug.Print("Exception when calling PartiesApi.PostPartiesCollection: " + ex.Message);
                    }
                }
                else
                {
                    MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Vous ne pouvez ajouter que 8 obstacles !", "Erreur");
                }

                //Association Partie Obstacle Position
                //A faire
            }
            else
            {
                MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Vous devez remplir tous les champs !","Erreur");
            }
        }

        private void PartiesRefresh_Click(object sender, RoutedEventArgs e)
        {
            AffichagePartie();
        }

        private void AffichagePartie()
        {
            List<Parties> listParties;
            DateTime date = (DateTime)reservationsDatePicker.SelectedDate;
            string dateString = date.ToString("yyyy-MM-dd");

            partiesListview.Items.Clear();

            try
            {
                listParties = partiesApi.GetByDate(dateString);
                Joueur joueurPartie;

                foreach (Parties partie in listParties)
                {
                    joueurPartie = joueurApi.GetByIdjoueur(partie.Idjoueurpartie.Substring(9, 1));
                    partiesListview.Items.Add(new Partie { ID = partie.Idpartie, Pseudo = joueurPartie.Pseudo, Heure = partie.Dateheuredebutpartie });
                }

            }
            catch (Exception ex)
            {

                Debug.Print("Exception calling method PartiesApi.GetByDate:" + ex.Message);
            }
        }

        private void AffichageJoueurs()
        {
            try
            {
                List<Joueur> joueurs = joueurApi.GetJoueurCollection();

                foreach (Joueur joueur in joueurs)
                {
                    pseudoReserverCombobox.Items.Add(joueur.Pseudo);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling joueurApi.GetJoueurCollection: " + e.Message);
            }
        }

        private void AffichageObstaclesDispo()
        {
            List<Obstacles> obstaclesDispo = obstaclesApi.GetObstaclesCollection();
            try
            {
                foreach (Obstacles obstacle in obstaclesDispo)
                {
                    obstaclesDispoListView.Items.Add(new Obstacle() { id = obstacle.Idobstacle, nomObstacle = obstacle.Typeobstacle });
                }
            }
            catch (Exception ex)
            {
                Debug.Print("Exeception calling method " + ex.Message);
            }
        }
    }
}


