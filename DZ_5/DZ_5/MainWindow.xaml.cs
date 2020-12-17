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

namespace DZ_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Room Tom = new Room();
        Room Bob = new Room(1, 1, 1);
        Room Bill = new Room(2, 2, 4, 4);
        Room John = new Room(3, 1, 154, 10);
        Room Tom1 = new Room(3, 3, 3);
        



        List<Room> Rooms = new List<Room>();




        public MainWindow()
        {
            InitializeComponent();

            Rooms.Add(Tom);
            Rooms.Add(Bob);
            Rooms.Add(Bill);
            Rooms.Add(John);
            Rooms.Add(Tom1);
            


            // вывод всех
            tb.Text = "All Rooms:";
            tb.Text = tb.Text + "\n----------------";

            for (int i = 0; i < Rooms.Count; i++)
            {
                tb.Text = tb.Text + "\nRoom number: " + (i + 1);
                tb.Text = tb.Text + "\n";
                tb.Text = tb.Text + (Rooms[i].info());
                tb.Text = tb.Text + "\n----------------";
            }

        }

        private void AddRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            double n_double;
            int n_int;
                
            if (double.TryParse(footage.Text, out n_double) == false||(double.Parse(footage.Text)<0))
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (double.TryParse(ceilingHeight.Text, out n_double) ==false || (double.Parse(ceilingHeight.Text) < 0))
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (double.TryParse(a.Text, out n_double) == false || (double.Parse(a.Text) < 0))
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (double.TryParse(b.Text, out n_double) == false || (double.Parse(b.Text) < 0))
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (int.TryParse(windows.Text, out n_int) == false || (double.Parse(windows.Text) < 0))
            {
                MessageBox.Show("Ошибка");
                return;
            }

            try
            {
                Room UserRoom = new Room
                {
                    Footage = double.Parse(footage.Text),
                    Height = double.Parse(ceilingHeight.Text),
                    A = double.Parse(a.Text),
                    B = double.Parse(b.Text),
                    Windows = int.Parse(windows.Text)

                };
                Rooms.Add(UserRoom);
            }
            catch { }

            tb.Text = "All Rooms:";
            tb.Text = tb.Text + "\n----------------";

            for (int i = 0; i < Rooms.Count; i++)
            {
                tb.Text = tb.Text + "\nRoom number: " + (i + 1);
                tb.Text = tb.Text + "\n";
                tb.Text = tb.Text + (Rooms[i].info());
                tb.Text = tb.Text + "\n----------------";
            }
        }

        private void rbKnowFootage_Checked(object sender, RoutedEventArgs e)
        {
            a.Visibility = Visibility.Hidden;
            b.Visibility = Visibility.Hidden;
            a_lb.Visibility = Visibility.Hidden;
            b_lb.Visibility = Visibility.Hidden;
            footage.Visibility = Visibility.Visible;
            f_lb.Visibility = Visibility.Visible;
            a.Text = "" + 0;
            b.Text = "" + 0;
            footage.Text = "";
        }

        private void rbForgotFootage_Checked(object sender, RoutedEventArgs e)
        {
            footage.Visibility = Visibility.Hidden;
            footage.Text = "" + 0;
            f_lb.Visibility = Visibility.Hidden;
            a.Visibility = Visibility.Visible;
            b.Visibility = Visibility.Visible;
            a_lb.Visibility = Visibility.Visible;
            b_lb.Visibility = Visibility.Visible;
            b.Text = "";
            a.Text = "";

        }
    }
}