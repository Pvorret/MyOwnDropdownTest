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

namespace TestMedDropDownOgListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>();
        List<string> boxlist = new List<string>();
        List<string> klist = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            list.Add("Joe");
            list.Add("Jack");
            list.Add("Jesse");
            list.Add("James");
            list.Add("Jolan");
            list.Add("Jo");

            boxlist.Add("Jennifer");
            boxlist.Add("Julia");
            boxlist.Add("Jane");
            boxlist.Add("Jillian");

            klist.Add("New Year");
            klist.Add("Christmas");
            klist.Add("Birthday");
        }

        private void TestDrop_DropDownOpened(object sender, EventArgs e)
        {
            foreach (string name in list)
            {
                TestDrop.Items.Add(name);
            }    
        }

        private void TestDrop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string name in boxlist)
            {
                TestListLeft.Items.Remove(name);   
            }
            if (list[0] == TestDrop.SelectedItem)
            {
                foreach (string name in boxlist)
                {
                    TestListLeft.Items.Add(name);
                }
            }
            
        }

        private void TestListLeft_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string name in klist)
            {
                TestListRight.Items.Remove(name);
            }
            if (boxlist[1] == TestListLeft.SelectedItem)
            {
                foreach (string name in klist)
                {
                    TestListRight.Items.Add(name);
                }
            }
        }

        private void Refreshbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            main.Show();
            Close();

        }

        private void TestListRight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (klist[2] == TestListRight.SelectedItem)
            {
                Refreshbtn.IsEnabled = true;
            }
        }
    }
}
