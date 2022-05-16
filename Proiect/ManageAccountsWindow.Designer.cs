
namespace ProiectISS
{
    partial class ManageAccountsWindow
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.addTypebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addUsernameBox = new System.Windows.Forms.TextBox();
            this.addPasswordBox = new System.Windows.Forms.TextBox();
            this.addLastnameBox = new System.Windows.Forms.TextBox();
            this.addFirstnameBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.updateLastnameBox = new System.Windows.Forms.TextBox();
            this.updateFirstnameBox = new System.Windows.Forms.TextBox();
            this.updatePasswordBox = new System.Windows.Forms.TextBox();
            this.updateUsernameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updateTypeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(3, 9);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(88, 33);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "<TYPE>";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-6, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADD";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(97, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 347);
            this.label2.TabIndex = 2;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPanel.Controls.Add(this.button5);
            this.addPanel.Controls.Add(this.addLastnameBox);
            this.addPanel.Controls.Add(this.addFirstnameBox);
            this.addPanel.Controls.Add(this.addPasswordBox);
            this.addPanel.Controls.Add(this.addUsernameBox);
            this.addPanel.Controls.Add(this.label6);
            this.addPanel.Controls.Add(this.label5);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.addTypebox);
            this.addPanel.Location = new System.Drawing.Point(113, 9);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(428, 309);
            this.addPanel.TabIndex = 5;
            this.addPanel.Visible = false;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Transparent;
            this.updatePanel.Controls.Add(this.button7);
            this.updatePanel.Controls.Add(this.updateLastnameBox);
            this.updatePanel.Controls.Add(this.updateFirstnameBox);
            this.updatePanel.Controls.Add(this.updatePasswordBox);
            this.updatePanel.Controls.Add(this.updateUsernameBox);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.label9);
            this.updatePanel.Controls.Add(this.label10);
            this.updatePanel.Controls.Add(this.updateTypeBox);
            this.updatePanel.Location = new System.Drawing.Point(113, 9);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(428, 309);
            this.updatePanel.TabIndex = 6;
            this.updatePanel.Visible = false;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.Transparent;
            this.deletePanel.Controls.Add(this.button6);
            this.deletePanel.Controls.Add(this.dgvDelete);
            this.deletePanel.Location = new System.Drawing.Point(113, 9);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(428, 309);
            this.deletePanel.TabIndex = 7;
            this.deletePanel.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-6, 46);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-6, 100);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(-6, 154);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvAccounts);
            this.panel2.Location = new System.Drawing.Point(113, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 309);
            this.panel2.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(-6, 279);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 12;
            this.button4.Text = "LOG OUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 29);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(420, 277);
            this.dgvAccounts.TabIndex = 0;
            // 
            // addTypebox
            // 
            this.addTypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTypebox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypebox.FormattingEnabled = true;
            this.addTypebox.Items.AddRange(new object[] {
            "Admin",
            "Tester",
            "Programmer"});
            this.addTypebox.Location = new System.Drawing.Point(14, 172);
            this.addTypebox.Name = "addTypebox";
            this.addTypebox.Size = new System.Drawing.Size(132, 24);
            this.addTypebox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last Name";
            // 
            // addUsernameBox
            // 
            this.addUsernameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsernameBox.Location = new System.Drawing.Point(14, 30);
            this.addUsernameBox.Name = "addUsernameBox";
            this.addUsernameBox.Size = new System.Drawing.Size(132, 23);
            this.addUsernameBox.TabIndex = 5;
            // 
            // addPasswordBox
            // 
            this.addPasswordBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPasswordBox.Location = new System.Drawing.Point(253, 30);
            this.addPasswordBox.Name = "addPasswordBox";
            this.addPasswordBox.Size = new System.Drawing.Size(132, 23);
            this.addPasswordBox.TabIndex = 6;
            // 
            // addLastnameBox
            // 
            this.addLastnameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLastnameBox.Location = new System.Drawing.Point(253, 120);
            this.addLastnameBox.Name = "addLastnameBox";
            this.addLastnameBox.Size = new System.Drawing.Size(132, 23);
            this.addLastnameBox.TabIndex = 8;
            // 
            // addFirstnameBox
            // 
            this.addFirstnameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFirstnameBox.Location = new System.Drawing.Point(14, 120);
            this.addFirstnameBox.Name = "addFirstnameBox";
            this.addFirstnameBox.Size = new System.Drawing.Size(132, 23);
            this.addFirstnameBox.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(14, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add account";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToAddRows = false;
            this.dgvDelete.AllowUserToDeleteRows = false;
            this.dgvDelete.AllowUserToResizeColumns = false;
            this.dgvDelete.AllowUserToResizeRows = false;
            this.dgvDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(4, 3);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.RowHeadersVisible = false;
            this.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelete.Size = new System.Drawing.Size(419, 269);
            this.dgvDelete.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(4, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(14, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // updateLastnameBox
            // 
            this.updateLastnameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLastnameBox.Location = new System.Drawing.Point(253, 120);
            this.updateLastnameBox.Name = "updateLastnameBox";
            this.updateLastnameBox.Size = new System.Drawing.Size(132, 23);
            this.updateLastnameBox.TabIndex = 18;
            // 
            // updateFirstnameBox
            // 
            this.updateFirstnameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFirstnameBox.Location = new System.Drawing.Point(14, 120);
            this.updateFirstnameBox.Name = "updateFirstnameBox";
            this.updateFirstnameBox.Size = new System.Drawing.Size(132, 23);
            this.updateFirstnameBox.TabIndex = 17;
            // 
            // updatePasswordBox
            // 
            this.updatePasswordBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePasswordBox.Location = new System.Drawing.Point(253, 30);
            this.updatePasswordBox.Name = "updatePasswordBox";
            this.updatePasswordBox.Size = new System.Drawing.Size(132, 23);
            this.updatePasswordBox.TabIndex = 16;
            // 
            // updateUsernameBox
            // 
            this.updateUsernameBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUsernameBox.Location = new System.Drawing.Point(14, 30);
            this.updateUsernameBox.Name = "updateUsernameBox";
            this.updateUsernameBox.Size = new System.Drawing.Size(132, 23);
            this.updateUsernameBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Username";
            // 
            // updateTypeBox
            // 
            this.updateTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateTypeBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTypeBox.FormattingEnabled = true;
            this.updateTypeBox.Items.AddRange(new object[] {
            "Admin",
            "Tester",
            "Programmer"});
            this.updateTypeBox.Location = new System.Drawing.Point(14, 172);
            this.updateTypeBox.Name = "updateTypeBox";
            this.updateTypeBox.Size = new System.Drawing.Size(132, 24);
            this.updateTypeBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Manage employee accounts";
            // 
            // ManageAccountsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageAccountsWindow";
            this.Text = "Manage Accounts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageAccountsWindow_FormClosed);
            this.Load += new System.EventHandler(this.ManageAccountsWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.ComboBox addTypebox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox addLastnameBox;
        private System.Windows.Forms.TextBox addFirstnameBox;
        private System.Windows.Forms.TextBox addPasswordBox;
        private System.Windows.Forms.TextBox addUsernameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox updateLastnameBox;
        private System.Windows.Forms.TextBox updateFirstnameBox;
        private System.Windows.Forms.TextBox updatePasswordBox;
        private System.Windows.Forms.TextBox updateUsernameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox updateTypeBox;
        private System.Windows.Forms.Label label11;
    }
}