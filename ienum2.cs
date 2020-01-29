using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference2
{
    class ienum2
    {
        static void Main(string[] args)
        {
            List<int> rollno = new List<int>();
            rollno.Add(1630);
            rollno.Add(1631);
            rollno.Add(1632);
            rollno.Add(1633);
            rollno.Add(1634);
            rollno.Add(1635);
            rollno.Add(1636);
            rollno.Add(1637);
            IEnumerable<int> roll = (IEnumerable<int>)rollno;
            IEnumerator<int> roll1 = rollno.GetEnumerator();
            iterate30to33(roll1);
            //foreach(int i in roll)
            //{
            //    Console.WriteLine(i);
            //}
            //while(roll1.MoveNext())
            //{
            //    Console.WriteLine(roll1.Current.ToString());
            //}
        }
        static void iterate30to33(IEnumerator<int> it)
        {
            while(it.MoveNext())
            {
                Console.WriteLine(it.Current.ToString());
                if((Convert.ToInt16(it.Current)>1633))
                    {
                    iterate33to37(it);
                }
            }
        }
        static void iterate33to37(IEnumerator<int> it)
        {
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current.ToString());
            }
        }
    }
}
