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
        List<RaceCar> raceCars = new List<RaceCar>();
        List<Student> students = new List<Student>();
        List<object> fanFiction = new List<object>();

        public MainWindow()
        {
            InitializeComponent();
            // Notes on github
            // Notes for github Desktop
            Preload();
            Display();

            PreloadStudent();
            DisplayStudent();

            // This disclares an anonymous type
            object robloxKombat = new
            {
                Name = "Kitana",
                Shirt = "Blue Tank Top",
                Weapon = "Bladed Fan",
                Head = (students[0].CsiGrade + students[0].GenEdGrade) / 2
            };

            fanFiction.Add(robloxKombat);
            fanFiction.Add(new { 
                Name = "Cap",
                Shirt = "Red",
                Weapon = "Axe",
                Head = false
            });

            DisplayList<object>(fanFiction, lvFanFiction);

            // Anonymous Type
            // Mortal Kombat
            // Roblox
            // - Name
            // - Shirt
            // - Weapon
            // - Head
      
        }

        public void DisplayList<T>(List<T> list, ListView lv)
        {
            lv.Items.Clear();

            foreach (T item in list)
            {
                lv.Items.Add(item);
            }
        }

        public void DisplayStudent()
        {
            lvStudent.Items.Clear();

            foreach (Student student in students)
            {
                lvStudent.Items.Add(student);
            }
        }



        public void Display()
        {
            lvRaceCars.Items.Clear();

            foreach (RaceCar race in raceCars)
            {
                lvRaceCars.Items.Add(race);
            }
        }

  

        public void PreloadStudent()
        {
            Student will = new Student("Will", "Cram", 17, 67);
            Student anne = new Student("Anne", "Nguyen");
            Student Ronda = new Student("Ronda", "R");

            students.Add(will);
            students.Add(anne);
            students.Add(Ronda);
        }

        public void Preload()
        {
            RaceCar rc1 = new RaceCar("V12", "Red", 100, 100, "12");
            raceCars.Add(rc1);
            raceCars.Add(new RaceCar("V18", "Blue", 12, 1, "7"));

        }


    }
}
