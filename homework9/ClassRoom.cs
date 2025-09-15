using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class ClassRoom
    {
        private List<StudentBase> Students;

        public ClassRoom(List<StudentBase> students)
        {
            Students = students;
        }

        public void ShowAll()
        {
            foreach (var s in Students)
            {
                s.Study();
                s.Read();
                s.Write();
                s.Relax();
                Console.WriteLine();
            }
        }
    }
}
