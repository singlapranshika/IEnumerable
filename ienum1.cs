using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference2
{
    class ienum1
    {
        public static void Main(string[] args)
        {
            List<int> Rollno = new List<int>();
            Rollno.Add(1630);
            Rollno.Add(1631);
            Rollno.Add(1632);
            Rollno.Add(1633);
            Rollno.Add(1634);
            Rollno.Add(1635);
            Rollno.Add(1636);
            Rollno.Add(1637);
            IEnumerable<int> Roll = (IEnumerable<int>)Rollno;
            Iterate1630to33(Roll);
        }

        static void Iterate1630to33(IEnumerable<int> it)
        {
            foreach (int i in it)
            {
                Console.WriteLine(i);
                if (i > 1633)
                {
                    Iterate1633to37(it);
                }

            }
        }
        static void Iterate1633to37(IEnumerable<int> it)
        {
            foreach (int i in it)
            {
                Console.WriteLine(i);
            }
        }
    }
}
