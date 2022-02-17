namespace Payment_App_1._0
{
    partial class Views
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.lvPayments = new System.Windows.Forms.ListView();
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmListMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(161, 197);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(97, 23);
            this.btnMakePayment.TabIndex = 1;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(275, 170);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(64, 20);
            this.txtPayment.TabIndex = 3;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(176, 173);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(79, 13);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Amount to Pay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payments";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(264, 83);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(75, 20);
            this.txtPaid.TabIndex = 6;
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.Location = new System.Drawing.Point(264, 109);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(75, 20);
            this.txtBalanceDue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "£";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(230, 86);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(28, 13);
            this.lblPaid.TabIndex = 9;
            this.lblPaid.Text = "Paid";
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(189, 112);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(69, 13);
            this.lblBalanceDue.TabIndex = 10;
            this.lblBalanceDue.Text = "Balance Due";
            // 
            // lvPayments
            // 
            this.lvPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAmount,
            this.colDate});
            this.lvPayments.ContextMenuStrip = this.cmListMenu;
            this.lvPayments.FullRowSelect = true;
            this.lvPayments.HideSelection = false;
            this.lvPayments.Location = new System.Drawing.Point(12, 44);
            this.lvPayments.MultiSelect = false;
            this.lvPayments.Name = "lvPayments";
            this.lvPayments.Size = new System.Drawing.Size(143, 176);
            this.lvPayments.TabIndex = 11;
            this.lvPayments.UseCompatibleStateImageBehavior = false;
            this.lvPayments.View = System.Windows.Forms.View.Details;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.Width = 49;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 89;
            // 
            // cmListMenu
            // 
            this.cmListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDateToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.cmListMenu.Name = "cmListMenu";
            this.cmListMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // editDateToolStripMenuItem
            // 
            this.editDateToolStripMenuItem.Name = "editDateToolStripMenuItem";
            this.editDateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editDateToolStripMenuItem.Text = "Edit Date";
            this.editDateToolStripMenuItem.Click += new System.EventHandler(this.editDateToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removeItemToolStripMenuItem.Text = "Remove";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvPayments);
            this.Controls.Add(this.lblBalanceDue);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalanceDue);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMakePayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Views";
            this.Text = "Payment App";
            this.Load += new System.EventHandler(this.Views_Load);
            this.cmListMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtPayment;
        public System.Windows.Forms.Label lblPayment;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPaid;
        public System.Windows.Forms.TextBox txtBalanceDue;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPaid;
        public System.Windows.Forms.Label lblBalanceDue;
        public System.Windows.Forms.ListView lvPayments;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ContextMenuStrip cmListMenu;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editDateToolStripMenuItem;
    }
}

