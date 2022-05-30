
namespace ProiectISS
{
    partial class TesterWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBugsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSeverity = new System.Windows.Forms.ComboBox();
            this.textPriority = new System.Windows.Forms.ComboBox();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.viewBugsPanel = new System.Windows.Forms.Panel();
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.addBugsPanel.SuspendLayout();
            this.viewBugsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tester";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(86, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 333);
            this.label2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(-17, 261);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "LOG OUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-17, 62);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "View bugs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-17, 116);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Bugs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBugsPanel
            // 
            this.addBugsPanel.BackColor = System.Drawing.Color.Transparent;
            this.addBugsPanel.Controls.Add(this.label5);
            this.addBugsPanel.Controls.Add(this.label4);
            this.addBugsPanel.Controls.Add(this.textSeverity);
            this.addBugsPanel.Controls.Add(this.textPriority);
            this.addBugsPanel.Controls.Add(this.textDescription);
            this.addBugsPanel.Controls.Add(this.label3);
            this.addBugsPanel.Controls.Add(this.button3);
            this.addBugsPanel.Location = new System.Drawing.Point(102, 12);
            this.addBugsPanel.Name = "addBugsPanel";
            this.addBugsPanel.Size = new System.Drawing.Size(286, 298);
            this.addBugsPanel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Severity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Priority";
            // 
            // textSeverity
            // 
            this.textSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSeverity.FormattingEnabled = true;
            this.textSeverity.Items.AddRange(new object[] {
            "Low",
            "Minor",
            "Major",
            "Critical"});
            this.textSeverity.Location = new System.Drawing.Point(137, 184);
            this.textSeverity.Name = "textSeverity";
            this.textSeverity.Size = new System.Drawing.Size(94, 21);
            this.textSeverity.TabIndex = 5;
            // 
            // textPriority
            // 
            this.textPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textPriority.FormattingEnabled = true;
            this.textPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.textPriority.Location = new System.Drawing.Point(17, 184);
            this.textPriority.Name = "textPriority";
            this.textPriority.Size = new System.Drawing.Size(94, 21);
            this.textPriority.TabIndex = 4;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(17, 35);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(214, 108);
            this.textDescription.TabIndex = 3;
            this.textDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 24);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add bug";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewBugsPanel
            // 
            this.viewBugsPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewBugsPanel.Controls.Add(this.dgvBugs);
            this.viewBugsPanel.Location = new System.Drawing.Point(102, 12);
            this.viewBugsPanel.Name = "viewBugsPanel";
            this.viewBugsPanel.Size = new System.Drawing.Size(286, 298);
            this.viewBugsPanel.TabIndex = 17;
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AllowUserToDeleteRows = false;
            this.dgvBugs.AllowUserToResizeColumns = false;
            this.dgvBugs.AllowUserToResizeRows = false;
            this.dgvBugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Location = new System.Drawing.Point(3, 3);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.ReadOnly = true;
            this.dgvBugs.RowHeadersVisible = false;
            this.dgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBugs.Size = new System.Drawing.Size(280, 285);
            this.dgvBugs.TabIndex = 2;
            // 
            // TesterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBugsPanel);
            this.Controls.Add(this.addBugsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TesterWindow";
            this.Text = "Add a bug";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TesterWindow_FormClosed);
            this.Load += new System.EventHandler(this.TesterWindow_Load);
            this.addBugsPanel.ResumeLayout(false);
            this.addBugsPanel.PerformLayout();
            this.viewBugsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel addBugsPanel;
        private System.Windows.Forms.Panel viewBugsPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textSeverity;
        private System.Windows.Forms.ComboBox textPriority;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBugs;
    }
}