using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PomazDS.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] words = value.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string lastWorld = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == lastWorld)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
