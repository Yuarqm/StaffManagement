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

namespace StaffManagement
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        
        public EmployeeListPage()
        {
            InitializeComponent();

            employeeDataGrid.ItemsSource = employees;
        }
        public static List<Employee> employees = new List<Employee>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeEditPage(employees));
        }

        private void EditEmpl_Click(object sender, RoutedEventArgs e)
        {
            if (employeeDataGrid.SelectedItem != null)
            {
                Employee selectedEmployee = (Employee)employeeDataGrid.SelectedItem;
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee,employees));
            }
        }

    }
}
