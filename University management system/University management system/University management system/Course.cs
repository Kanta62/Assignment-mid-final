using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    class Course
    {

        private string courseName;
        private string courseId;
        Section[] sections = new Section[10];

        public Course(string courseName, string courseId)
        {
            this.courseName = courseName;
            this.courseId = courseId;
        }

        public void insertSection(Section a)
        {
            for (int i = 0; i < 10; i++)
            {
                if (sections[i] == null)
                {
                    sections[i] = a;
                    break;
                }
            }
        }

        public void showSection()
        {
            for (int i = 0; i < 10; i++)
            {
                if (sections[i] != null)
                {
                    sections[i].showInfo();

                }
                else
                {
                    break;
                }
            }
        }
    }
}
