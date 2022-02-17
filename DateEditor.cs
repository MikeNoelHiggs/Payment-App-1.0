using Payment_App_1._0.Controller;
using Payment_App_1._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_App_1._0.View
{
    public partial class DateEditor : Form
    {
        public DateTime newDate;
        private ApplicationController Controller;
        public Payment payment;

    
        public DateEditor(ApplicationController c, Payment p)
        {
            InitializeComponent();
            this.Controller = c;
            this.payment = p;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newDate = dp.Value;
            Controller.RunEditDate();
            this.Hide();
        }

    }
}
