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

namespace Traveluuu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Closerbtn_Checked(object sender, RoutedEventArgs e)
            => Close();

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            AddUserControl(userControl);
        }
        public void AddUserControl(UserControl userControl)
        {
            MenuPanel.Children.Clear();
            MenuPanel.Children.Add(userControl);
        }

        private void AddNewBtn_click(object sender, RoutedEventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl();
            AddUserControl(userControl);

        }
    }
}
