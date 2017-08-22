using ERPSystem.Entities;
using ERPSystem.Repository;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestDataBinding.Infrastructure;

namespace ERPSystem.Infrastructure
{
    class ViewRepository : INotifyPropertyChanged
    {
        private Employee selectedEmployee;
        private Employee newEmployee;
        private ObservableCollection<Employee> employeeList;
        private ObservableCollection<Project> projectList;

        public ObservableCollection<Employee> EmployeeList
        {
            get { if (employeeList == null) employeeList = EmployeeBase.Employees; return employeeList; }
            set => employeeList = value;
        }
        public ObservableCollection<Project> ProjectList
        {
            get { if (projectList == null) projectList = ProjectBase.Projects; return projectList; }
            set => projectList = value;
        }

        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        public Employee NewEmployee
        {
            get
            {
                if (newEmployee == null)
                {
                    newEmployee = new Employee();
                    newEmployee.Id = EmployeeList.Count;
                }
                return newEmployee;
            }
            set
            {
                newEmployee = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
            


        #region Commands

        private ICommand addEmployee;
        private ICommand openImage;                

        public ICommand AddEmployee
        {
            get
            {
                if (addEmployee == null)
                {
                    addEmployee = new DelegateCommand(AddNewEmployee, CanAddNewEmployee);
                }
                return addEmployee;
            }
        }
        public ICommand OpenImage
        {
            get
            {
                if (openImage == null)
                {
                    openImage = new DelegateCommand(OpenPhoto);
                }
                return openImage;
            }
        }



        public bool MyDialogResult
        {
            get { return MyDialogResult; }
            set { MyDialogResult = value; }
        }
        
        private void AddNewEmployee(object param)
        {
            AddNewEmployeeWindow x = new AddNewEmployeeWindow();
            x.DataContext = this;          
            newEmployee = new Employee() { Id = EmployeeList.Count + 1 };
            if (x.ShowDialog() == true)
            {
                foreach (var item in projectList)
                {
                    if (item.IsChecked == true)
                    {
                        newEmployee.ThisEmployeeProjects.Add(item);
                        item.IsChecked = false;
                    }
                }
                newEmployee.Effeciency.UpdateEffeciencyValues();
                newEmployee.Rating = newEmployee.Effeciency.CountRating();
                EmployeeList.Add(newEmployee);
                OnPropertyChanged("EmployeeList");
            }
            else newEmployee = null;
        }

        private bool CanAddNewEmployee(object param)
        {
            return true;
        }

        private void OpenPhoto(object param)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                NewEmployee.Photo = ofd.FileName;
                OnPropertyChanged("NewEmployee");
            }
        }

        

        #endregion



    }
}
