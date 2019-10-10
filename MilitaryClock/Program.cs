using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MilitaryClock
{
    class Program
    {
        static void Main()
        {
            int sec = 0;
            int min = 0;
            int hr = 0;
            int count = 0;
            int delay = 300;
            Console.CursorVisible=false;        //no need for visible cursor
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetWindowSize(10, 3);
            while (count<86400)                 //comes from multiplying 60 sec with 60 hrs with 24 hrs.
            {
                Console.WriteLine($"{hr}:{min}:{sec}");
                if (sec<=59)
                {
                    sec++;
                }
                else
                {
                    sec = 0;
                    min++;
                    Console.Clear();        // call clear when sec resets to clear the extra digit in the seconds place
                }
                if (min > 59)               
                {
                    min = 0;
                    hr++;
                }
                if (hr > 23)
                {
                    hr = 0;
                }
                Thread.Sleep(delay);    //implements a delay of 1 sec(configurable with delay)
                try
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);    //trying to call setcursor after con.clear causes execption. catch it.

                }
                catch (ArgumentOutOfRangeException)
                {
                    //catch exeption and just move foward.
                } 
                count++;
               
            }
        }
    }
}
