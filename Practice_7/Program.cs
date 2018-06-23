using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new HashSet<char>(new[] { 'a', 'b', 'c', 'd'});
            List<String> l = new List<String>();
            foreach (var s in AddAllFrom(chars, 3)) // 3 -- длина
                l.Add(s);


            foreach (var s in l.OrderBy(i=>i)) // сортировка по полю, указанному Лямбда - выражением
                Console.WriteLine(s);
        }

        static IEnumerable<string> AddAllFrom(HashSet<char> chars, int n)
        {
            if (n == 0)
                yield return "";
            foreach (var c in chars.ToList())
            {
                chars.Remove(c);
                foreach (var s in AddAllFrom(chars, n - 1))
                    yield return c + s;
                chars.Add(c);
            }
        }
    }
}
