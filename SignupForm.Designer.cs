namespace CarSales {
    partial class SignupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.usernameTextBoxSignUpForm = new System.Windows.Forms.TextBox();
            this.passwordTextBoxSignUpForm = new System.Windows.Forms.TextBox();
            this.SignUpButtonSignUpForm = new System.Windows.Forms.Button();
            this.backButtonSignUpForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordTextboxSignUpForm = new System.Windows.Forms.TextBox();
            this.password1Visible = new System.Windows.Forms.CheckBox();
            this.password2Visible = new System.Windows.Forms.CheckBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBoxSignUpForm
            // 
            this.usernameTextBoxSignUpForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBoxSignUpForm.Location = new System.Drawing.Point(192, 177);
            this.usernameTextBoxSignUpForm.Name = "usernameTextBoxSignUpForm";
            this.usernameTextBoxSignUpForm.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBoxSignUpForm.TabIndex = 0;
            // 
            // passwordTextBoxSignUpForm
            // 
            this.passwordTextBoxSignUpForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBoxSignUpForm.Location = new System.Drawing.Point(192, 220);
            this.passwordTextBoxSignUpForm.Name = "passwordTextBoxSignUpForm";
            this.passwordTextBoxSignUpForm.PasswordChar = '*';
            this.passwordTextBoxSignUpForm.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBoxSignUpForm.TabIndex = 1;
            // 
            // SignUpButtonSignUpForm
            // 
            this.SignUpButtonSignUpForm.Location = new System.Drawing.Point(129, 335);
            this.SignUpButtonSignUpForm.Name = "SignUpButtonSignUpForm";
            this.SignUpButtonSignUpForm.Size = new System.Drawing.Size(75, 23);
            this.SignUpButtonSignUpForm.TabIndex = 3;
            this.SignUpButtonSignUpForm.Text = "Sign Up";
            this.SignUpButtonSignUpForm.UseVisualStyleBackColor = true;
            this.SignUpButtonSignUpForm.Click += new System.EventHandler(this.SignUpButtonSignUpForm_Click);
            // 
            // backButtonSignUpForm
            // 
            this.backButtonSignUpForm.Location = new System.Drawing.Point(278, 335);
            this.backButtonSignUpForm.Name = "backButtonSignUpForm";
            this.backButtonSignUpForm.Size = new System.Drawing.Size(75, 23);
            this.backButtonSignUpForm.TabIndex = 4;
            this.backButtonSignUpForm.Text = "Back";
            this.backButtonSignUpForm.UseVisualStyleBackColor = true;
            this.backButtonSignUpForm.Click += new System.EventHandler(this.backButtonSignUpForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "SIGN UP";
            // 
            // confirmPasswordTextboxSignUpForm
            // 
            this.confirmPasswordTextboxSignUpForm.Location = new System.Drawing.Point(192, 263);
            this.confirmPasswordTextboxSignUpForm.Name = "confirmPasswordTextboxSignUpForm";
            this.confirmPasswordTextboxSignUpForm.PasswordChar = '*';
            this.confirmPasswordTextboxSignUpForm.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTextboxSignUpForm.TabIndex = 2;
            // 
            // password1Visible
            // 
            this.password1Visible.AutoSize = true;
            this.password1Visible.Location = new System.Drawing.Point(299, 222);
            this.password1Visible.Name = "password1Visible";
            this.password1Visible.Size = new System.Drawing.Size(41, 17);
            this.password1Visible.TabIndex = 10;
            this.password1Visible.Text = "👁 ";
            this.password1Visible.UseVisualStyleBackColor = true;
            this.password1Visible.CheckedChanged += new System.EventHandler(this.password1Visible_CheckedChanged);
            // 
            // password2Visible
            // 
            this.password2Visible.AutoSize = true;
            this.password2Visible.Location = new System.Drawing.Point(299, 265);
            this.password2Visible.Name = "password2Visible";
            this.password2Visible.Size = new System.Drawing.Size(41, 17);
            this.password2Visible.TabIndex = 11;
            this.password2Visible.Text = "👁 ";
            this.password2Visible.UseVisualStyleBackColor = true;
            this.password2Visible.CheckedChanged += new System.EventHandler(this.password2Visible_CheckedChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(131, 180);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.password2Visible);
            this.Controls.Add(this.password1Visible);
            this.Controls.Add(this.confirmPasswordTextboxSignUpForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButtonSignUpForm);
            this.Controls.Add(this.SignUpButtonSignUpForm);
            this.Controls.Add(this.passwordTextBoxSignUpForm);
            this.Controls.Add(this.usernameTextBoxSignUpForm);
            this.MaximizeBox = false;
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBoxSignUpForm;
        private System.Windows.Forms.TextBox passwordTextBoxSignUpForm;
        private System.Windows.Forms.Button SignUpButtonSignUpForm;
        private System.Windows.Forms.Button backButtonSignUpForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordTextboxSignUpForm;
        private System.Windows.Forms.CheckBox password1Visible;
        private System.Windows.Forms.CheckBox password2Visible;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}