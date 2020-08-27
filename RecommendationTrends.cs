using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace River_East_WebAPI
{
    public class RecommendationTrends
    {
        private string symbol;
        private int buy;
        private int hold;
        private DateTime period;
        private int sell;
        private int strongBuy;
        private int strongSell;

        public string Symbol { get => symbol; set => symbol = value; }
        public int Buy { get => buy; set => buy = value; }
        public int Hold { get => hold; set => hold = value; }
        public DateTime Period { get => period; set => period = value; }
        public int Sell { get => sell; set => sell = value; }
        public int StrongBuy { get => strongBuy; set => strongBuy = value; }
        public int StrongSell { get => strongSell; set => strongSell = value; }
    }
}
