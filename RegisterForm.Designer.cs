
namespace UniEats_Alpha
{
    partial class RegisterForm
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
            this.SignupBotton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswrodLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTypeDropDown = new System.Windows.Forms.ComboBox();
            this.PasswordHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignupBotton
            // 
            this.SignupBotton.BackColor = System.Drawing.Color.Black;
            this.SignupBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBotton.ForeColor = System.Drawing.SystemColors.Control;
            this.SignupBotton.Location = new System.Drawing.Point(46, 445);
            this.SignupBotton.Name = "SignupBotton";
            this.SignupBotton.Size = new System.Drawing.Size(226, 72);
            this.SignupBotton.TabIndex = 12;
            this.SignupBotton.Text = "SIGN UP";
            this.SignupBotton.UseVisualStyleBackColor = false;
            this.SignupBotton.Click += new System.EventHandler(this.SignupBotton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(43, 126);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(198, 55);
            this.RegisterLabel.TabIndex = 11;
            this.RegisterLabel.Text = "Sign-Up";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(46, 291);
            this.PasswordTextBox.MaxLength = 16;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(226, 26);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(46, 218);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(226, 23);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.BackgroundImage = global::UniEats_Alpha.Properties.Resources.BackArrow;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.Location = new System.Drawing.Point(46, 61);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(20, 26);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Sih";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(43, 192);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(111, 17);
            this.UsernameLabel.TabIndex = 14;
            this.UsernameLabel.Text = "Enter Username";
            // 
            // PasswrodLabel
            // 
            this.PasswrodLabel.AutoSize = true;
            this.PasswrodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswrodLabel.Location = new System.Drawing.Point(43, 262);
            this.PasswrodLabel.Name = "PasswrodLabel";
            this.PasswrodLabel.Size = new System.Drawing.Size(107, 17);
            this.PasswrodLabel.TabIndex = 15;
            this.PasswrodLabel.Text = "Enter Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(43, 342);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(38, 17);
            this.UserLabel.TabIndex = 16;
            this.UserLabel.Text = "User";
            // 
            // UserTypeDropDown
            // 
            this.UserTypeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeDropDown.FormattingEnabled = true;
            this.UserTypeDropDown.Items.AddRange(new object[] {
            "Student",
            "Driver/Rider",
            "Restaurant"});
            this.UserTypeDropDown.Location = new System.Drawing.Point(46, 372);
            this.UserTypeDropDown.Name = "UserTypeDropDown";
            this.UserTypeDropDown.Size = new System.Drawing.Size(175, 24);
            this.UserTypeDropDown.TabIndex = 17;
            this.UserTypeDropDown.Text = "Select a User";
            // 
            // PasswordHide
            // 
            this.PasswordHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordHide.BackgroundImage = global::UniEats_Alpha.Properties.Resources.PasswordIcon;
            this.PasswordHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordHide.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordHide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordHide.Location = new System.Drawing.Point(225, 291);
            this.PasswordHide.Name = "PasswordHide";
            this.PasswordHide.Size = new System.Drawing.Size(47, 26);
            this.PasswordHide.TabIndex = 19;
            this.PasswordHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PasswordHide.UseVisualStyleBackColor = false;
            this.PasswordHide.Click += new System.EventHandler(this.PasswordHide_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniEats_Alpha.Properties.Resources.IphoneBack;
            this.ClientSize = new System.Drawing.Size(315, 634);
            this.Controls.Add(this.PasswordHide);
            this.Controls.Add(this.UserTypeDropDown);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswrodLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignupBotton);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.BackButton);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignupBotton;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswrodLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ComboBox UserTypeDropDown;
        private System.Windows.Forms.Button PasswordHide;
    }
}