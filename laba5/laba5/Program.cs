using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameofTrial = null;
            try
            {
                Trial test = new Trial(nameofTrial);
            }
            catch(trialexecein e)
            {
                Console.WriteLine(@"возникла ошибка"+e.Message);
            }
            finally{
                Console.WriteLine("но вы можете ее решить");
            }
            int[] arr = new int[5];

            try
            {
                arr[6] = 5;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try{
                arr[7] = 8;
            }
            catch(Exception e){
                Console.WriteLine("очень плохая ошибка" + e.Source);
            }
            finally{
                Console.WriteLine("вы очень плохой человек");
            }
            Console.ReadKey();

        }
    }
}
