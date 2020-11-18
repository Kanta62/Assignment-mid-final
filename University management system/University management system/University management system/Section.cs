using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    class Section
    {
        private string sectionName;
        private string sectionTime;
        public Teacher teachername;

        public Section(string sectionName, string sectionTime)
        {
            this.sectionName = sectionName;
            this.sectionTime = sectionTime;
        }

        public void showInfo()
        {
            Console.WriteLine("Section name: " + sectionName);
            Console.WriteLine("Section time " + sectionTime);
            teachername.showInfo();
        }
    }
}
