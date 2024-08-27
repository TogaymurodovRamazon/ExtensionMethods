using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Collection_method
    {
        public static IEnumerable<int> FaqatJuftlar(this IEnumerable<int> sonlar)
        {
            foreach (int i in sonlar)
            {
                if( i%2==0)
                    //Console.WriteLine(i);
                yield return i;    // ekranga chiqarish 
            }
        }
    }
}
