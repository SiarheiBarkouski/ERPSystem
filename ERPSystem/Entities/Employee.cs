using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Entities
{
    class Employee
    {
        private int id;
        private string fio;
        private DateTime birth;
        private string address;
        private string photo;
        private int role;
        private int rating;
        ObservableCollection<Project> thisEmployeeProjects;
        EffeciencyValues effeciency;

        public Employee()
        {
            thisEmployeeProjects = new ObservableCollection<Project>();
            effeciency = new EffeciencyValues(new int[] {0, 0, 0 });
        }

        public int Id { get => id; set => id = value; }
        public string Fio { get => fio; set => fio = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Address { get => address; set => address = value; }
        public string Photo { get => photo; set => photo = value; }
        public int Role { get => role; set => role = value; }
        public int Rating { get => rating; set => rating = value; }
        public ObservableCollection<Project> ThisEmployeeProjects { get => thisEmployeeProjects; set => thisEmployeeProjects = value; }
        public EffeciencyValues Effeciency
        {
            get => effeciency;
            set
            {
                effeciency = value;
                if (effeciency != null)
                {
                    rating = effeciency.CountRating();
                }
            }
        }

    }
}
