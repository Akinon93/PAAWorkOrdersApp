namespace PAAWorkOrdersApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.company_name = new System.Windows.Forms.TextBox();
            this.purchase_order_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Continue";
            this.button1.Location = new System.Drawing.Point(583, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Work Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitWorkOrder);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Exit";
            this.button2.Location = new System.Drawing.Point(470, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel and Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExitApplication);
            // 
            // company_name
            // 
            this.company_name.Location = new System.Drawing.Point(436, 156);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(194, 20);
            this.company_name.TabIndex = 2;
            // 
            // purchase_order_number
            // 
            this.purchase_order_number.Location = new System.Drawing.Point(436, 265);
            this.purchase_order_number.Name = "purchase_order_number";
            this.purchase_order_number.Size = new System.Drawing.Size(194, 20);
            this.purchase_order_number.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purchase Order #:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(30, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 423);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Click += new System.EventHandler(this.AddNewAccessory);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.purchase_order_number);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.company_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Work Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 573);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.TextBox purchase_order_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

