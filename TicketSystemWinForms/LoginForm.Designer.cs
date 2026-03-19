namespace TicketSystemWinForms
{
    partial class LoginForm
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(294, 186);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 31);
            txtUser.TabIndex = 0;
            txtUser.Text = "User Name";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(294, 255);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(150, 31);
            txtPass.TabIndex = 1;
            txtPass.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 189);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 2;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 255);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
    }
}