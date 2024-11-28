using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CalculatorService<T> where T : Product
    {
        public static T max<T>(List<T> obj) where T : IComparable<T>
        {
            {
                T index = obj[0];
                foreach (var item in obj)
                {
                    if (item.CompareTo(index) > 0)
                    {
                        index = item;
                    }
                }
                return index;
            };
        }
    }
}