using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payment_App_1._0.Controller;
using Payment_App_1._0.Model;


namespace Payment_App_1._0
{
    public partial class Views : Form
    {
        private UserModel model;
        private ApplicationController controller;

        public Views()
        {
            InitializeComponent();
            model = new UserModel();
            controller = new ApplicationController(model, this);
            Setup();
            controller.LoadData();
        }

        public void Setup()
        {
            controller.SetTextFields();
        }

        public void setText(string txtBalanceDueText, string txtPaidText)
        {
            txtBalanceDue.Text = txtBalanceDueText;
            txtPaid.Text = txtPaidText;
        }

        public void setText(string txtPaymentText, string txtBalanceDueText, string txtPaidText)
        {
            txtPayment.Text = txtPaymentText;
            txtBalanceDue.Text = txtBalanceDueText;
            txtPaid.Text = txtPaidText;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (txtPayment.Text == null || txtPayment.Text == "")
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                controller.MakePayment(Convert.ToInt32(txtPayment.Text));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controller.SaveData();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RemoveItem();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SaveData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.LoadData();
        }

        private void editDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.EditDate();  
        }

        private void Views_Load(object sender, EventArgs e)
        {

        }
    }
}
