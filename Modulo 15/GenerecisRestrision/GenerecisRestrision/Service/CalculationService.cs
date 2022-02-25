using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerecisRestrision.Service
{
    class CalculationService
    {

        public int Max(List<int> list)
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("This list can not be empty");
            }
            int max = list[0];

            for(int i = 1;  i < list.Count; i++)
                if(list[i] > max)
                {
                    max = list[i];
                }
            return max;
        }

    }
}
