namespace Hut8BookRegistration
{
    partial class MainFrm
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
            this.allCustomersCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allBooksCbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regDateDtp = new System.Windows.Forms.DateTimePicker();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.registerBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allCustomersCbo
            // 
            this.allCustomersCbo.DropDownWidth = 200;
            this.allCustomersCbo.FormattingEnabled = true;
            this.allCustomersCbo.Location = new System.Drawing.Point(40, 70);
            this.allCustomersCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allCustomersCbo.Name = "allCustomersCbo";
            this.allCustomersCbo.Size = new System.Drawing.Size(375, 28);
            this.allCustomersCbo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book:";
            // 
            // allBooksCbo
            // 
            this.allBooksCbo.FormattingEnabled = true;
            this.allBooksCbo.Location = new System.Drawing.Point(40, 170);
            this.allBooksCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allBooksCbo.Name = "allBooksCbo";
            this.allBooksCbo.Size = new System.Drawing.Size(375, 28);
            this.allBooksCbo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registration Date:";
            // 
            // regDateDtp
            // 
            this.regDateDtp.Location = new System.Drawing.Point(40, 270);
            this.regDateDtp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regDateDtp.Name = "regDateDtp";
            this.regDateDtp.Size = new System.Drawing.Size(375, 26);
            this.regDateDtp.TabIndex = 7;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(450, 30);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(150, 78);
            this.addCustomerBtn.TabIndex = 2;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(450, 130);
            this.addBookBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(150, 78);
            this.addBookBtn.TabIndex = 5;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            // 
            // registerBookBtn
            // 
            this.registerBookBtn.Location = new System.Drawing.Point(450, 230);
            this.registerBookBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerBookBtn.Name = "registerBookBtn";
            this.registerBookBtn.Size = new System.Drawing.Size(150, 78);
            this.registerBookBtn.TabIndex = 8;
            this.registerBookBtn.Text = "Register Book";
            this.registerBookBtn.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 344);
            this.Controls.Add(this.registerBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.regDateDtp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allBooksCbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allCustomersCbo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.Text = "Hut8 Book Registration";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox allCustomersCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allBooksCbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker regDateDtp;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button registerBookBtn;
    }
}

