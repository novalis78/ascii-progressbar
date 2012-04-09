using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsciiProgressBar
{
    class AsciiBar
    {
        private int stepsOnScreen = 2;
        private int sizeOfBar = 50;
        private int upping = 0;
        private int decimals = 2;

        /// <summary>
        /// Create AsciiBar Object specifying amount of steps to draw for each progress increment
        /// </summary>
        /// <param name="cursorSteps"></param>
        public AsciiBar(int cursorSteps)
        { 
            //init
            if ((cursorSteps > 2) || (cursorSteps <= 0))
                Console.WriteLine("Progress step on screen can only be 1 or 2");
            else
            {
                stepsOnScreen = cursorSteps;
                upping = cursorSteps;
            }
        }

        /// <summary>
        /// Create AsciiBar Object specifying amount of steps to draw for each progress increment
        /// plus specifying an option for precision of percentage
        /// </summary>
        /// <param name="cursorSteps"></param>
        /// <param name="decimals"></param>
        public AsciiBar(int cursorSteps, int d)
        {
            new AsciiBar(cursorSteps);
            decimals = d;
        }

        /// <summary>
        /// Paints an ascii progress bar based on the two input values
        /// </summary>
        /// <param name="total_size"></param>
        /// <param name="current_size"></param>
        public void AsciiProgressBar(int total_size, int current_size)
        {
            double percent = 0.0;
            int count = current_size;
            string output = "";
            double onePercent = (total_size / 100.0);
            percent = System.Math.Round(current_size / onePercent, 2);

            if (percent >= upping)
            {
                upping += 2;
            }
            else if(percent < stepsOnScreen)
            {
                output = "\r" + percent + "%\t[";
                for (int f = upping; f < sizeOfBar; f++)
                    output += "_";
                output += "]";
                Console.Write("\r + " + output);
            }
            else if (percent >= 99.99)
            {
                output = "\r" + "DONE!" + "%\t[";
                for (int i = 0; i <= upping / 2; i++)
                    output += "=";
                output += ">";
                output += "]";
                Console.Write("\r + " + output);
            }
            else
            {
                output = "\r" + percent + "%\t[";
                for (int i = 0; i <= upping / 2; i++)
                    output += "=";
                output += ">";
                for (int f = upping / 2; f < sizeOfBar; f++)
                    output += "_";
                output += "]";
                Console.Write("\r + " + output);
            }
            
        }
    }
}
