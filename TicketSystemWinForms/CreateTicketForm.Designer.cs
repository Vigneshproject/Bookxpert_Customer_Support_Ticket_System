namespace TicketSystemWinForms
{
    partial class CreateTicketForm
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
            txtSubject = new TextBox();
            txtDesc = new TextBox();
            cmbPriority = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(270, 87);
            txtSubject.Multiline = true;
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(200, 40);
            txtSubject.TabIndex = 0;
            txtSubject.Text = "Subject";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(271, 168);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(200, 80);
            txtDesc.TabIndex = 1;
            txtDesc.Text = "Description";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(270, 278);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(182, 33);
            cmbPriority.TabIndex = 2;
            cmbPriority.Text = "Priority";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 90);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 3;
            label1.Text = "Subject :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 181);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 4;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 281);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "Priority :";
            // 
            // CreateTicketForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPriority);
            Controls.Add(txtDesc);
            Controls.Add(txtSubject);
            Name = "CreateTicketForm";
            Text = "CreateTicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubject;
        private TextBox txtDesc;
        private ComboBox cmbPriority;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}