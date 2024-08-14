using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.Sections
{
    public class WeatherGen
    {
        string[] conditionTemplate = { "Sunny", "Rainy", "Snowy", "Windy" };
        Random RNG = new Random();

        /// <summary>
        /// Generates random Temperatures and Condtitions, and Calculaes Statistics about them
        /// </summary>
        public void GenerateWeather() 
        {
            Console.Write("Enter Amount Of Days: ");
            int days = int.Parse(Console.ReadLine()); 
            int[] temps = new int[days];
            string[] conditions = new string[days];
            for (int i=0; i < days; i++) 
            {
                temps[i] = RNG.Next(-30,30);
                conditions[i] = conditionTemplate[RNG.Next(0,conditionTemplate.Length)];
            }
            foreach (int temp in temps) Console.WriteLine(temp);
            foreach (string cond in conditions) Console.WriteLine(cond);
            Console.WriteLine($"The Min And Max Temps Are: {MinMax(temps)}");
            Console.WriteLine($"The Most Common Temp is {CommonWeather(temps, conditions, true)} and the most Common Weather Type is {CommonWeather(temps, conditions, false)}");
            Console.ReadLine();
        }
        /// <summary>
        /// Calculates Min And Max Temps
        /// </summary>
        /// <param name="temps"></param>
        /// <returns></returns>
        public string MinMax(int[] temps)
        {
            int min = temps[0], max= temps[0];
            foreach (int i in temps)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
            return ($"{min}, {max}"); 
        }
        /// <summary>
        /// Calculates Most Common Temperature and Condition
        /// </summary>
        /// <param name="temps"></param>
        /// <param name="conditions"></param>
        /// <param name="isTemp"></param>
        /// <returns></returns>
        public string CommonWeather(int[] temps, string[] conditions, bool isTemp)
        {
            int count = 0, countTemp = 0;

            if (isTemp)
            {
                int mostCommonTemp = 0;
                foreach (int i in temps)
                {
                    for (int j = 0; j < temps.Length; j++)
                    {
                        if (i == temps[j]) countTemp++;
                    }
                    if (countTemp > count)
                    {
                        count = countTemp; mostCommonTemp = i;
                    }
                    countTemp = 0;
                }
                return ($"{mostCommonTemp}");
            }
            else
            {
                string mostCommonCond = "";
                foreach (string f in conditions)
                {
                    for (int j = 0; j < conditions.Length; j++)
                    {
                        if (f == conditions[j]) countTemp++;
                    }
                    if (countTemp > count)
                    {
                        count = countTemp; mostCommonCond = f;
                    }
                    countTemp = 0;
                }
                return ($"{mostCommonCond}");
            }
            
        }
    }
}
