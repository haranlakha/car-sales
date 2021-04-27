
namespace CarSales {
    partial class AccountForm {
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
            this.deleteAccountBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.secondPassVisible = new System.Windows.Forms.CheckBox();
            this.firstPassVisible = new System.Windows.Forms.CheckBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteAccountBtn.Location = new System.Drawing.Point(182, 319);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(120, 23);
            this.deleteAccountBtn.TabIndex = 0;
            this.deleteAccountBtn.Text = "Delete Account";
            this.deleteAccountBtn.UseVisualStyleBackColor = true;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirm Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(156, 180);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 20;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondPassVisible
            // 
            this.secondPassVisible.AutoSize = true;
            this.secondPassVisible.Location = new System.Drawing.Point(324, 265);
            this.secondPassVisible.Name = "secondPassVisible";
            this.secondPassVisible.Size = new System.Drawing.Size(41, 17);
            this.secondPassVisible.TabIndex = 19;
            this.secondPassVisible.Text = "👁 ";
            this.secondPassVisible.UseVisualStyleBackColor = true;
            this.secondPassVisible.CheckedChanged += new System.EventHandler(this.secondPasswordVisible_CheckedChanged);
            // 
            // firstPassVisible
            // 
            this.firstPassVisible.AutoSize = true;
            this.firstPassVisible.Location = new System.Drawing.Point(324, 222);
            this.firstPassVisible.Name = "firstPassVisible";
            this.firstPassVisible.Size = new System.Drawing.Size(41, 17);
            this.firstPassVisible.TabIndex = 18;
            this.firstPassVisible.Text = "👁 ";
            this.firstPassVisible.UseVisualStyleBackColor = true;
            this.firstPassVisible.CheckedChanged += new System.EventHandler(this.firstPasswordVisible_CheckedChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(217, 263);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(100, 20);
            this.confirmPassword.TabIndex = 17;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.Location = new System.Drawing.Point(217, 220);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 16;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(217, 177);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 15;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.secondPassVisible);
            this.Controls.Add(this.firstPassVisible);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.deleteAccountBtn);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteAccountBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox secondPassVisible;
        private System.Windows.Forms.CheckBox firstPassVisible;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}