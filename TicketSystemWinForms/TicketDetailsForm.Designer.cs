namespace TicketSystemWinForms
{
    partial class TicketDetailsForm
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
            lblNo = new TextBox();
            lblStatus = new TextBox();
            cmbStatus = new ComboBox();
            txtComment = new TextBox();
            btnAssign = new Button();
            btnStatus = new Button();
            btnComment = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNo
            // 
            lblNo.Location = new Point(294, 47);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(150, 31);
            lblNo.TabIndex = 0;
            lblNo.Text = "TicketNo";
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(295, 84);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(150, 31);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Open", "In Progress", "Closed" });
            cmbStatus.Location = new Point(294, 121);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 2;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(294, 160);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(150, 60);
            txtComment.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(294, 226);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(112, 34);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(294, 266);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(112, 34);
            btnStatus.TabIndex = 5;
            btnStatus.Text = "Change Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnComment
            // 
            btnComment.Location = new Point(294, 306);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(112, 34);
            btnComment.TabIndex = 6;
            btnComment.Text = "Add Comment";
            btnComment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 7;
            label1.Text = "TicketNo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 8;
            label2.Text = "Status :";
            // 
            // TicketDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComment);
            Controls.Add(btnStatus);
            Controls.Add(btnAssign);
            Controls.Add(txtComment);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblNo);
            Name = "TicketDetailsForm";
            Text = "TicketDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblNo;
        private TextBox lblStatus;
        private ComboBox cmbStatus;
        private TextBox txtComment;
        private Button btnAssign;
        private Button btnStatus;
        private Button btnComment;
        private Label label1;
        private Label label2;
    }
}