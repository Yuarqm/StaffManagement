using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StaffManagement
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private int currPay;

        public int Id { get { return id; } set { id = value; } }    
        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                {
                    MessageBox.Show("Возраст сотрудника слишком мелкий для работы ");
                }
                else
                {
                    age = value;
                }
            }
        }
                
        public int CurrentPay
        {
            get { return currPay; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Кто бесплатно работает?");
                }
                else
                {
                    currPay = value;
                }
            }
        }
        public Employee(int id, string name, int age,int currentPay)
        {
            Id = id;
            Name = name;
            Age = age;         
            CurrentPay = currentPay;
        }

    }
}
