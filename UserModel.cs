using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_App_1._0.Model
{
    [Serializable]
    public class UserModel
    {
        private int payed;
        private int balanceDue;
        private List<Payment> payments;

        public int Payed
        {
            get { return payed; }
            set { payed = value; }
        }

        public int BalanceDue
        {
            get { return balanceDue; }
            set { balanceDue = value; }
        }

        public List<Payment> Payments
        {
            get { return payments; }
            set { payments = value; }
        }

        public UserModel()
        {
            this.payed = 0;
            this.balanceDue = 17500;
            payments = new List<Payment>();

        }

        public UserModel(int payed, int BalanceDue, List<Payment> Payments)
        {
            this.payed = Payed;
            this.balanceDue = BalanceDue;
            this.payments = Payments;
        }

        public UserModel GetModel()
        {
            return this;
        }

        public void SortList()
        {
            payments = payments.OrderBy(p => p.Date).ToList<Payment>();
        }

    }
}
