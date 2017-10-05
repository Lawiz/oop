using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace laba4
{
    class Set
    {
        public List<int> _list;


        Set()
        {
            _list = new List<int>();
            
        }
        public Set(params int[] args)
      : this()
        {
            _list.AddRange(args);
        }
        public Set(IEnumerable<int> mas)
      : this()
        {
            _list.AddRange(mas);
        }
        // перегрузка ++
        public static Set operator ++(Set obj1)
        {
            Random rnd = new Random();
            obj1._list.Add(rnd.Next(1, 40));
            return obj1;
        }

        public void Delete(int elem)
        {
            _list.Remove(elem);
        }
        // перегрузка +
        public static Set operator +(Set obj1, Set obj2)
        {
            //Set result = new Set();
            //result._list =(List<int>) obj1._list.Union(obj2._list);
            //return result;

            Set result = new Set();
            result._list.AddRange(obj1._list);
            for(int index_1=0;index_1<obj2._list.Count;index_1++)
            {
                int count = 0;
                for(int index_2=0;index_2<obj1._list.Count;index_2++)
                {
                    if (obj2._list[index_1] == obj1._list[index_2])
                        count++;
                }
                if (count == 0)
                    result._list.Add(obj2._list[index_1]);

            }
            return result;
        }
        // разность множеств
        public Set Except(List<int> Source)
        {
            return new Set(_list.Except(Source));
        }
        public override string ToString()
        {
            return string.Join(",", _list);
        }
        //перегрузка неявного инт

        public static implicit operator int(Set p)
        {
            return p._list.Count();
        }
        //доступ к элементу
        public static int operator %(Set obj, int index)
        {
            return obj._list[index];
        }
        //вложенный метод шифрования
        public static class StringExtenction
        {
            public static string Extenction(Set p)
            {
                int mas = 0;
                foreach (int i in p._list)
                {
                    mas += p._list[i];
                }
                mas = mas / 2 * 40 + 1;
                return mas.ToString();
            }
        }
        // вложенная проверка на упорядоченность
        public static class StreamlineMany
        {
            public static List<int> Streamline(Set m)
            {
                m._list.Sort();
                return m._list;
            }
        }
        class CretionDate
        {
            private static DateTime creationData;
            public DateTime CretionData
            {
                get
                {
                    return creationData;
                }
                set
                {
                    creationData = CretionData;
                }
            }

            class owner
            {
                public string Name { get; set; }
                public string ID { get; set; }
                public string Organization { get; set; }

                public override string ToString()
                {
                    return Name + " " + ID + " " + Organization;
                }
            }

            class testSet
            {
                public static void Main()
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;


                    void printList(List<int> p)
                    {
                        for (var index = 0; index < p.Count; index++)
                        {
                            Console.Write(p[index] + " ");
                        }

                    }


                    Set set_1 = new Set(1,2,3,4,5);
                    Set set_2 = new Set(1,2,8,9,0);
                   
                    Console.WriteLine("первое множнство");
                    printList(set_1._list);
                    Console.WriteLine("");



                    Console.WriteLine("второе множество");
                    printList(set_2._list);
                    Console.WriteLine("");


                    Console.WriteLine("перегрузка +");
                    Set resultOperetionMas = new Set();
                    resultOperetionMas = set_1 + set_2;
                    printList(resultOperetionMas._list);
                    Console.WriteLine("");


                    Console.WriteLine("перегрузка ++");
                    Set resultOperationIncriment = new Set();
                    resultOperetionMas = set_1++;
                    printList(resultOperetionMas._list);
                    Console.WriteLine("");


                    Console.Write("дата создания  ");
                    CretionDate dataOfcreate = new CretionDate();
                    Console.WriteLine(dataOfcreate.CretionData);

                    Console.Write("владулуец ");
                    owner owner_1 = new owner();
                    Console.WriteLine(owner_1.ToString());

                    Console.ReadKey();
                }

            }

        }


    }
}

