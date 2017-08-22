using ERPSystem.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Repository
{
    static class ProjectBase
    {
        private static ObservableCollection<Project> projects;
        public static ObservableCollection<Project> Projects { get => projects; set => projects = value; }

        static ProjectBase()
        {
            projects = new ObservableCollection<Project>();
            CreateTestProjects();
        }

        private static void CreateTestProjects()
        {
            projects.Add(new Project()
            {
                ProjectName = "ConstrutorProject",
                ClientName = "BelPromStroi",
                DateBegin = new DateTime(2016, 1, 1),
                DateEnd = new DateTime(2017, 1, 1),
                PercentageOfCompletion = 100                
            });

            projects.Add(new Project()
            {
                ProjectName = "FinancialProject",
                ClientName = "Alpari",
                DateBegin = new DateTime(2015, 1, 1),
                DateEnd = new DateTime(2018, 1, 1),
                PercentageOfCompletion = 75
            });

            projects.Add(new Project()
            {
                ProjectName = "AnalyticProject",
                ClientName = "PVT",
                DateBegin = new DateTime(2016, 1, 1),
                DateEnd = new DateTime(2019, 1, 1),
                PercentageOfCompletion = 25
            });
        }

    }
}
