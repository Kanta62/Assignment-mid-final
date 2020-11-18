using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_management_system
{
    class Program
    {
        static void Main(string[] args)

        {

            Department cse = new Department("CSE");
            Course db = new Course("Algorithm", "1010");
            Course dm = new Course("Java", "2020");
            Course eco = new Course("Database", "3030");
            cse.insertCourse(dm);
            cse.insertCourse(dm);
            cse.insertCourse(eco);
            Section a = new Section("A", "12.50");
            Section b = new Section("B", "15.50");
            db.insertSection(a);
            db.insertSection(b);
            Teacher x = new Teacher("AAAAA", "57675", 19);
            x.insertSection(a);
            a.teachername = x;
            x.insertSection(b);
            b.teachername = x;
            db.showSection();
            x.showSection();

        }
    }
}
