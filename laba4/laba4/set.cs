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
        public static  Set operator ++(Set obj1)
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
            return (Set) obj1._list.Union(obj2._list);
        }
        // разность множеств
        public  Set Except(List<int> Source)
        {
            return new Set(_list.Except(Source)); 
        }
        public override string ToString ()
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
                int mas=0;
                foreach(int i in p._list)
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
            public DateTime CretionData { get { return creationData; } }
          
        }
        class owner
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Organization { get; set; }
           
        }
        
       

    }

}
