using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatadorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MatadorPlayer mp = new MatadorPlayer();

            int turnsTaken = 100;

            for (int i = 0; i < turnsTaken; i++)
            {
                mp.TakeTurn();
            }

            List<int> result = mp.GetResult();
            
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(i + ": " + ((double)(result[i]*100)/(double)turnsTaken) + "%");
            }

            while (true)
            {
                
            }
        }
    }
}
