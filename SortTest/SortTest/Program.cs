using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Unit_7_IT481

{

    /// <summary>

    /// MainApp startup class for Real-World 

    /// Strategy Design Pattern.

    /// </summary>

    class MainApp

    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()

        {

            // Two contexts following different strategies
            using (var reader = new StreamReader(@"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt"))
            {
                string line;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    SortedList assortNames = new MergeSort(@"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt");
                    
                    assortNames.SetSortStrategy(new ShellSort(@"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt"));
                    assortNames.SetSortStrategy(@"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt");
                    assortNames.SetSortStrategy(@"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt");

                    assortNames.Sort();

                    // Wait for user

                    Console.ReadKey();

                }
            }
        }

    /// <summary>

            /// The 'Strategy' abstract class

            /// </summary>

        abstract class SortStrategy

        {

            public abstract void Sort(List<string> list);

        }

        /// <summary>

        /// A 'ConcreteStrategy' class

        /// </summary>

        class QuickSort : SortStrategy

        {
            private string v;

            public QuickSort(string v)
            {
                this.v = v;
            }

            public override void Sort(List<string> list)

            {

                list.Sort(); // Default is Quicksort

                Console.WriteLine("QuickSorted list ");

            }
        }

        /// <summary>

        /// A 'ConcreteStrategy' class

        /// </summary>

        class ShellSort : SortStrategy
        {
            
            public ShellSort(string v)
            {
                           }
                        public override void Sort(List<string> list)

            {

                //list.ShellSort(); not-implemented

                Console.WriteLine("ShellSorted list ", @"C:\Users\Sue\Desktop\IT 481\Data Text File 100.txt");

            }
        }

        /// <summary>

        /// A 'ConcreteStrategy' class

        /// </summary>

        class MergeSort : SortStrategy

        {
            private string v;

            public MergeSort(string v)
            {
                this.v = v;
            }

            public override void Sort(List<string> list)

            {

                //list.MergeSort(); not-implemented

                Console.WriteLine("MergeSorted list ");

            }

        }


        /// <summary>


        /// </summary>

        class SortedList
        {
            private List<string> _list = new List<string>();

            private SortStrategy _sortstrategy;
            private string v;

            public SortedList(string v)
            {
                this.v = v;
            }

            public void SetSortStrategy(SortStrategy sortstrategy)

            {
                this._sortstrategy = sortstrategy;

            }

            public void Add(string name)



            {

                _list.Add(name);

            }

            public void Sort()

            {

                _sortstrategy.Sort(_list);

                // Iterate over list and display results

                foreach (string name in _list)

                {

                    Console.WriteLine(" " + name);

                }

                Console.WriteLine();

            }

            public override string ToString()
            {
                return base.ToString();
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            internal void SetSortStrategy(string v)
            {
                throw new NotImplementedException();
            }

            public static implicit operator SortedList(MergeSort v)
            {
                throw new NotImplementedException();
            }

            public static implicit operator SortedList(QuickSort v)
            {
                throw new NotImplementedException();
            }
        }


    }
}

