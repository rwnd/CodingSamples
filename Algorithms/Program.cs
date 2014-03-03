using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Combinatorics obj = new Combinatorics();
            int[] array = new int[] { 1, 2, 3, 4, 5};
            obj.Permute(array);
            obj.Combine(array);
        }
    }
}
