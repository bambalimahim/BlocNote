using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EditeurFichier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Nom du fichier à utiliser
        /// </summary>
        private string nomFichier = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
            boutonEnregistrer.IsEnabled = false;
        }

        /// <summary>
        /// Ouvrir le fichier après la sélection par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoutonOuvrir_Click(object sender, RoutedEventArgs e)
        {
            // TODO - Mettre à jour la méthode BoutonOuvrir_Click 
            // Appel méthode LireNomFichier pour avoir le nom du fichier à charger           
           nomFichier = LireNomFichier();
           if(nomFichier != String.Empty)
            {
                //editeur.Text = EntreesSortiesTexte.LireTexte(nomFichier);
                editeur.Text = EntreesSortiesTexte.FiltrerTexte(nomFichier);

            }
        }

        // TODO - Implémenter une méthode pour lire le nom du fichier 
        // Ajouter une méthode LireNomFichier 
        public String LireNomFichier()
        {
            String fnom = String.Empty;
            OpenFileDialog selOuvrir = new OpenFileDialog(); // Créer instance. (); // Créer instance. (); // Créer instance. (); // Créer instance. (); // Créer instance. (); // Créer instance. (); // Créer instance.
            selOuvrir.InitialDirectory = @"C:\Souche1";
            selOuvrir.DefaultExt = ".txt";
            selOuvrir.Title = "Rechercher un fichier à ouvrir"; // Renseigner lesRechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner lesRechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner lesRechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner lesRechercher un fichier à ouvrir"; // Renseigner les Rechercher un fichier à ouvrir"; // Renseigner lesRechercher un fichier à ouvrir"; // Renseigner les
            selOuvrir.Filter = "Texte Documents(.txt) |*.txt;"; // propriétés. // propriétés. // propriétés.
            bool? retourSowhDialog = selOuvrir.ShowDialog(); // Afficher dialogue sélection. // Afficher dialogue sélection. // Afficher dialogue sélection. // Afficher dialogue sélection. // Afficher dialogue sélection.// Afficher dialogue sélection. // Afficher dialogue sélection.// Afficher dialogue sélection. // Afficher dialogue sélection. // Afficher dialogue sélection.
            fnom = retourSowhDialog == true ? selOuvrir.FileName : fnom;
            return fnom;
        }

        // Enregistrer les données à nouveau dans le fichier
        private void BoutonEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            // TODO - Mettre à jour la méthode  BoutonEnregistrer_Click 
            // Enregistrer le contenu de la zone de texte de l'éditeur à nouveau dans le fichier
            
            String chemin = Enregistrer(editeur.Text);
            if(chemin != String.Empty)
            {
                EntreesSortiesTexte.EcrireTexte(chemin, editeur.Text);
                editeur.Text = "";
                MessageBox.Show("Enregistrement reussi !!!");
            }
            boutonEnregistrer.IsEnabled = false;
        }

        public String Enregistrer(String nomFichier)
        {
            SaveFileDialog selSauve = new SaveFileDialog (); // Créer instance. 
            selSauve.DefaultExt = "txt"; // Renseigner les 
            selSauve.OverwritePrompt = true ;// propriétés. // propriétés. // propriétés.
            selSauve.ShowDialog(); // Afficher dialogue sélection. // Afficher dialogue sélection. // Afficher dialogue sélection.
            return selSauve.FileName; // Lire chemin sélectionné . ;
        }
        
    
        private void editeur_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            boutonEnregistrer.IsEnabled = true;
            
        }
    } 
    
    
}
