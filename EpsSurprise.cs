using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace River_East_WebAPI
{
    public class EpsSurprise
    {
        private string symbol;
        private decimal estimate;
        private decimal actual;
        private DateTime period;

        public string Symbol { get => symbol; set => symbol = value; }
        public decimal Estimate { get => estimate; set => estimate = value; }
        public decimal Actual { get => actual; set => actual = value; }
        public DateTime Period { get => period; set => period = value; }
    }
}
