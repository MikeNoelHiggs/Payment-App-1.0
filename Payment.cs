using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_App_1._0.Model
{
    [Serializable]
    public class Payment
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Payment(int amount, DateTime date)
        {
            this.amount = amount;
            this.date = date;
        }
    }
}
