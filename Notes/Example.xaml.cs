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

namespace Prog_122_W23_Lecture_12_ListView.Notes
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Example : Window
    {

        List<object> listOfObjects = new List<object>();
        List<Player> listOfPlayers = new List<Player>();

        public Example()
        {
            InitializeComponent();
        }


        public void Example3()
        {
            PopulateObjects();

            listOfPlayers.Add(new Player("Will", 101));

            DisplayToListView<object>(listOfObjects, lvObjects);
            DisplayToListView<Player>(listOfPlayers, lvPlayers);
        }

        public void PopulateObjects()
        {
            listOfObjects.Add(new
            {
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
