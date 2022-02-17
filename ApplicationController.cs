using Payment_App_1._0.Model;
using Payment_App_1._0.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Payment_App_1._0.Controller
{
   public class ApplicationController
    {
        public UserModel model { get; set; }
        public Views view { get; set; }
        public DateEditor dateEditor { get; set; }

        private string txtPaymentText;
        private string txtPaidText;
        private string txtBalanceDueText;



        public ApplicationController(UserModel model, Views view)
        {
            this.model = model;
            this.view = view;
            txtPaymentText = "0";
            txtPaidText = "£" + this.model.Payed.ToString();
            txtBalanceDueText = "£" + this.model.BalanceDue.ToString();
            dateEditor = new DateEditor(this, null);
        }

        public void SetTextFields()
        {
            UpdateVariables();
            UpdateListView();
            view.setText(txtPaymentText, txtBalanceDueText, txtPaidText);
        }

        public void MakePayment(int amount)
        {
            AddToListView(amount);
            UpdateModel(amount);
            UpdateVariables();
            view.setText(txtBalanceDueText, txtPaidText);
        }


        private void UpdateModel(int amount)
        {
            model.Payments.Add(new Payment(amount, Convert.ToDateTime(DateTime.Now.ToShortDateString())));
            model.BalanceDue -= amount;
            model.Payed += amount;
        }

        private void UpdateVariables()
        {
            txtPaymentText = "0";
            txtPaidText = "£" + model.Payed.ToString();
            txtBalanceDueText = "£" + model.BalanceDue.ToString();
        }

        private void AddToListView(int amount)
        {
            ListViewItem item = new ListViewItem("£" + amount.ToString());
            item.SubItems.Add(DateTime.Now.ToShortDateString());
            view.lvPayments.Items.Add(item);
        }

        private void UpdateListView()
        {
            foreach (Payment p in model.Payments)
            {
                ListViewItem item = new ListViewItem("£" + p.Amount.ToString());
                item.SubItems.Add(p.Date.ToShortDateString());
                view.lvPayments.Items.Add(item);
            }
        }

        public void RemoveItem()
        {
            int amount = Convert.ToInt32(view.lvPayments.SelectedItems[0].Text.Remove(0, 1));

            model.BalanceDue += amount;
            model.Payed -= amount;

            model.Payments.RemoveAt(view.lvPayments.Items.IndexOf(view.lvPayments.SelectedItems[0]));

            Clear();
            SetTextFields();
        }

        public void EditDate()
        {
            try
            {
                Payment p = new Payment(Convert.ToInt32(view.lvPayments.SelectedItems[0].SubItems[0].Text.Substring(1)), Convert.ToDateTime(view.lvPayments.SelectedItems[0].SubItems[1].Text));
               
                dateEditor.payment = p;
                dateEditor.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Amount Field Selected", "Please Select an amount.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RunEditDate()
        {
            try
            {
                model.Payments.RemoveAt(view.lvPayments.Items.IndexOf(view.lvPayments.SelectedItems[0]));
                model.Payments.Add(new Payment(dateEditor.payment.Amount, dateEditor.newDate));
                model.SortList();
               
                Clear();
                SetTextFields();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Amount Field Selected", "Please Select an amount.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveData()
        {
            using (Stream stream = File.Open("C:\\Users\\Mike\\OneDrive\\Documents\\Programming\\C#\\source\\repos\\Payment App 1.0\\model\\SaveData", false ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, model);
            }
        }

        public void LoadData()
        {
            using (Stream stream = File.Open("C:\\Users\\Mike\\OneDrive\\Documents\\Programming\\C#\\source\\repos\\Payment App 1.0\\model\\SaveData", FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                model = (UserModel)binaryFormatter.Deserialize(stream);
                
            }
            Clear();
            SetTextFields();
        }

        private void Clear()
        {
            view.lvPayments.Items.Clear();
        }
    }
}
