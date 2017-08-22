using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Entities
{    
    class Project
    {        
        string projectName;
        string clientName;
        DateTime dateBegin;
        DateTime dateEnd;
        int percentageOfCompletion;
        bool isChecked;

        public Project()
        {
            isChecked = false;
        }

        public string ProjectName { get => projectName; set => projectName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public DateTime DateBegin { get => dateBegin; set => dateBegin = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        public int PercentageOfCompletion { get => percentageOfCompletion; set => percentageOfCompletion = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }
    }
}
