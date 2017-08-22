using ERPSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Entities
{
    class EffeciencyValues
    {        
        private KeyValuePair<string, int> teamworkEffeciency;
        private KeyValuePair<string, int> selfDevelopment;
        private KeyValuePair<string, int> percentOfCompletedProjects;
        private List<KeyValuePair<string, int>> effeciencyValuesList;
        private int teamworkEffeciency_;
        private int selfDevelopment_;
        private int percentOfCompletedProjects_;

        public EffeciencyValues(int [] values)
        {
            effeciencyValuesList = new List<KeyValuePair<string, int>>();
            teamworkEffeciency = new KeyValuePair<string, int>("Teamwork Effeciency", values[0]);
            selfDevelopment = new KeyValuePair<string, int>("Self-Development", values[1]);
            percentOfCompletedProjects = new KeyValuePair<string, int>("Percent of successfully\ncompleted projects", values[2]);
            effeciencyValuesList.Add(teamworkEffeciency);
            effeciencyValuesList.Add(selfDevelopment);
            effeciencyValuesList.Add(percentOfCompletedProjects);
        }

        public List<KeyValuePair<string, int>> EffeciencyValuesList { get => effeciencyValuesList; set => effeciencyValuesList = value; }
        public int TeamworkEffeciency_ { get => teamworkEffeciency_; set => teamworkEffeciency_ = value; }
        public int SelfDevelopment_ { get => selfDevelopment_; set => selfDevelopment_ = value; }
        public int PercentOfCompletedProjects_ { get => percentOfCompletedProjects_; set => percentOfCompletedProjects_ = value; }

        public int CountRating()
        {
            int sum = 0;            
            foreach (var item in effeciencyValuesList)
            {
                sum += item.Value;
            }
            return (int)Math.Round((decimal)(sum / effeciencyValuesList.Count / 20));
        }

        public static int[] GetRandom100Values(int count)
        {
            int[] a = new int[count];
            for (int i = 0; i < count; i++)
            {
                a[i] = Randomer.Next100();
            }
            return a;
        }

        public void UpdateEffeciencyValues()
        {
            teamworkEffeciency = new KeyValuePair<string, int>("Teamwork Effeciency", teamworkEffeciency_);
            selfDevelopment = new KeyValuePair<string, int>("Self-Development", selfDevelopment_);
            percentOfCompletedProjects = new KeyValuePair<string, int>("Percent of successfully\ncompleted projects", percentOfCompletedProjects_);
            effeciencyValuesList.Clear();
            effeciencyValuesList.Add(teamworkEffeciency);
            effeciencyValuesList.Add(selfDevelopment);
            effeciencyValuesList.Add(percentOfCompletedProjects);
        }

    }
}
