using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using System.IO;

namespace laba4
{
    class Set <universType1> 
    {

        public List<universType1> _list;
        //public void WriteToFile(List<string> list)
        //{
        //    string path = @"c:\temp\MyTest.txt";
        //    File.WriteAllLines(path,list);
        //}
        //public void ReadOfFile()
        //{
        //    _list.AddRange(File.ReadLines(path));
        //}

        public  void  Add(universType1 obj)
        {
            _list.Add(obj);
        }
        public  void Del()
        {
            _list.RemoveAt(1);
        }
        

         public universType1 LookAt(int index)
         {
            return _list[index];
         }
        

        Set()
        {
            _list = new List<universType1>();

        }
        public Set(params universType1[] args)
      : this()
        {
            if (args == null)
                throw new Exception();
                else
            _list.AddRange(args);

        }
        public Set(IEnumerable<universType1> mas)
      : this()
        {
            if (mas == null)
                throw new Exception();
            else
                _list.AddRange(mas);
        }
        public static bool operator ==(Set<universType1> obj1, Set<universType1> obj2)
        {
            if (obj1.Equals(obj2))
                return true;
            else
                return false;


        }
        public static bool operator !=(Set<universType1> obj1, Set<universType1> obj2)
        {
            if (obj1.Equals(obj2))
                return false;
            else
                return true;

        }

        // перегрузка ++
        public static Set<universType1> operator ++(Set<universType1> obj1)
        {
            universType1[] arrOfType = new universType1[10];
            Random rnd = new Random();

            obj1._list.Add(arrOfType[rnd.Next(0, 9)]);
            return obj1;
        }

        public void Delete(universType1 elem)
        {
            _list.Remove(elem);
        }
        // перегрузка +
        public static Set<universType1> operator +(Set<universType1> obj1, Set<universType1> obj2)
        {
            //Set result = new Set();
            //result._list =(List<int>) obj1._list.Union(obj2._list);
            //return result;

            Set<universType1> result = new Set<universType1>();
            result._list.AddRange(obj1._list);
            for (int index_1 = 0; index_1 < obj2._list.Count; index_1++)
            {
                int count = 0;
                for (int index_2 = 0; index_2 < obj1._list.Count; index_2++)
                {
                    if (obj2._list[index_1].Equals(obj2._list[index_2]))
                        count++;
                }
                if (count == 0)
                    result._list.Add(obj2._list[index_1]);

            }
            return result;
        }
        // разность множеств
        public Set<universType1> Except(List<universType1> Source)
        {
            return new Set<universType1>(_list.Except(Source));
        }
        public override string ToString()
        {
            return string.Join(",", _list);
        }
        //перегрузка неявного инт

        public static implicit operator int(Set<universType1> p)
        {
            return p._list.Count();
        }
        //доступ к элементу
        public static universType1 operator %(Set<universType1> obj, int index)
        {
            return obj._list[index];
        }
        //вложенный метод шифрования
        //public static class StringExtenction
        //{
        //    public static string Extenction(Set<universType1> p)
        //    {
        //        universType1 mas = 0;
        //        foreach (int i in p._list)
        //        {
        //            mas += p._list[i];
        //        }
        //        mas = mas / 2 * 40 + 1;
        //        return mas.ToString();
        //    }
        //}
        // вложенная проверка на упорядоченность
        public static class StreamlineMany
        {
            public static List<universType1> Streamline(Set<universType1> m)
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
        }
    }
}

          

