using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    class Department
    {
        private string departmentName;
        Course[] cources = new Course[10];

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void showInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void insertCourse(Course a)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cources[i] == null)
                {
                    cources[i] = a;
                    break;
                }
            }
        }
    }
}
