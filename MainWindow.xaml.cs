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

namespace Prog_122_W23_Lecture_12_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> listOfObjects = new List<object>();
        List<Player> listOfPlayers = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
            // Notes on github
        

        }

        public void Example()
        {
            PopulateObjects();

            listOfPlayers.Add(new Player("Will", 101));

            DisplayToListView<object>(listOfObjects, lvObjects);
            DisplayToListView<Player>(listOfPlayers, lvPlayers);
        }

        public void PopulateObjects()
        {
            listOfObjects.Add(new {
                FirstName = "Will",
                LastName = "Cram",
                Grade = 100
            });
        }

        public void DisplayToListView<T>(List<T> list, ListView lv)
        {
            lv.Items.Clear();

            foreach (T item in list)
            {
                lv.Items.Add(item);
            }
        }

    }
}
