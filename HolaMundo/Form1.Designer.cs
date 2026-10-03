namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            btnValidate = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 110);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            label1.Click += label1_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(149, 246);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(125, 27);
            txtConfirmPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(149, 333);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 3;
            btnValidate.Text = "validar";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 223);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirmar contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnValidate);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Button btnValidate;
        private Label label2;
    }
}
