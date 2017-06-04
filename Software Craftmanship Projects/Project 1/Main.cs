using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Main
    {
        static void main(string[] args) {
            List<string> a = populateA();
            List<string> b = populateB();
            Comparer<string> cmp = populateCmp();

        }

        static List<T> longestPrefix(List<T> a, List<T> b, Comparer<T> cmp) {
            IEnumerator<T> enum_a = a.GetEnumerator();
            IEnumerator<T> enum_b = b.GetEnumerator();

            List<T> result = new List<T>();

            while (enum_a.MoveNext() 
                    && enum_b.MoveNext()
                    && cmp.Compare(enum_a.Current, enum_b.Current) == 0) {
                result.Add(enum_a.Current);
            }


            return result;
        }

        private static List<string> populateA() {
            List <string> a = new List<string>();

            a.Add("a");
            a.Add("b");
            a.Add("c");
            a.Add("d");
            a.Add("e");
            a.Add("f");

            return a;
        }

        private static List<string> populateB()
        {
            List<string> b = new List<string>();

            b.Add("a");
            b.Add("b");
            b.Add("c");
            b.Add("c");
            b.Add("b");
            b.Add("a");

            return b;
        }

        private static Comparer<string> populateCmp() {
            Comparison<string>.
            return Comparer<T>.Create();
        }
    }
}
