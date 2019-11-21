using System;
using System.Collections.Generic;


namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var omega = new List<int>();
            foreach(int a in numbers)
            {
                if(a % 2 == 0)
                {
                    omega.Add(a);

                }
            }return omega.ToArray();
        }
    }
}
