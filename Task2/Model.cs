using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    
    class Model
    {
        private int s; 

        public string Tick()
        {
            s++;
            return s >= 60 ? (s / 60) + " секунд " + s % 60 + " миллисекунд" : s.ToString();
        }
        public void Reset()
        {
            s = 0;
        }
    }
}
