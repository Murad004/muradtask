using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomeTask
{
    class Card
    {
        public string Pan { get; set; }
        public string Pin { get; set; }
        public int Cvc { get; set; }
        public DateTime ExpiredTime { get; set; }
        public decimal Balance { get; set; }

    }
}
