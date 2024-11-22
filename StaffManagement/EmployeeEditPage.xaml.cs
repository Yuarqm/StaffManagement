using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для EmployeeEditPage.xaml
    /// </summary>
    public partial class EmployeeEditPage : Page
    {
        private Employee employee;
        private List<Employee> employees;
        public EmployeeEditPage(Employee emp, List<Employee> employees)
        {
            InitializeComponent();
            employee = emp;
            this.employees = employees;
            txtID.Text = Convert.ToString(employee.Id);
            txtName.Text = employee.Name;
            txtAge.Text = Convert.ToString(employee.Age);
            txtCurrPay.Text = Convert.ToString(employee.CurrentPay);
        }
        public EmployeeEditPage(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (employee != null)
            { 
                employees.Remove(employee);
                employee = new Employee(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtCurrPay.Text));
                if (employee.Age != 0 & employee.CurrentPay != 0)
                {
                    employees.Add(employee);
                    NavigationService.GoBack();
                }


            }
            else
            {

                employee = new Employee(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToInt32(txtCurrPay.Text));
                if (employee.Age != 0 & employee.CurrentPay != 0)
                {
                    employees.Add(employee);
                    NavigationService.GoBack();
                }
           
                
               
            }
        }
    }
}
