
namespace School_Management.Manager.Login
{
    partial class Login_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Account));
            this.Username_label = new DevExpress.XtraEditors.LabelControl();
            this.Password_label = new DevExpress.XtraEditors.LabelControl();
            this.User_text = new DevExpress.XtraEditors.TextEdit();
            this.Password_text = new DevExpress.XtraEditors.TextEdit();
            this.Login_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Cancel_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Create_Account = new DevExpress.XtraEditors.SimpleButton();
            this.Picture_login = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.User_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_login.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_label
            // 
            this.Username_label.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.Appearance.ForeColor = System.Drawing.Color.LightSalmon;
            this.Username_label.Appearance.Options.UseFont = true;
            this.Username_label.Appearance.Options.UseForeColor = true;
            this.Username_label.Location = new System.Drawing.Point(282, 60);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(79, 21);
            this.Username_label.TabIndex = 0;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Appearance.ForeColor = System.Drawing.Color.LightSalmon;
            this.Password_label.Appearance.Options.UseFont = true;
            this.Password_label.Appearance.Options.UseForeColor = true;
            this.Password_label.Location = new System.Drawing.Point(282, 133);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(76, 21);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Password";
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(382, 54);
            this.User_text.Name = "User_text";
            this.User_text.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_text.Properties.Appearance.Options.UseFont = true;
            this.User_text.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("User_text.Properties.ContextImageOptions.Image")));
            this.User_text.Size = new System.Drawing.Size(229, 36);
            this.User_text.TabIndex = 2;
            // 
            // Password_text
            // 
            this.Password_text.EditValue = "";
            this.Password_text.Location = new System.Drawing.Point(382, 122);
            this.Password_text.Name = "Password_text";
            this.Password_text.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_text.Properties.Appearance.Options.UseFont = true;
            this.Password_text.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Password_text.Properties.ContextImageOptions.SvgImage")));
            this.Password_text.Size = new System.Drawing.Size(229, 36);
            this.Password_text.TabIndex = 3;
            // 
            // Login_bt
            // 
            this.Login_bt.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_bt.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Login_bt.Appearance.Options.UseFont = true;
            this.Login_bt.Appearance.Options.UseForeColor = true;
            this.Login_bt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Login_bt.ImageOptions.SvgImage")));
            this.Login_bt.Location = new System.Drawing.Point(518, 245);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(93, 36);
            this.Login_bt.TabIndex = 4;
            this.Login_bt.Text = "Login";
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click);
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_bt.Appearance.Options.UseFont = true;
            this.Cancel_bt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Cancel_bt.ImageOptions.SvgImage")));
            this.Cancel_bt.Location = new System.Drawing.Point(382, 245);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(103, 36);
            this.Cancel_bt.TabIndex = 5;
            this.Cancel_bt.Text = "Cancel";
            // 
            // Create_Account
            // 
            this.Create_Account.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Account.Appearance.Options.UseFont = true;
            this.Create_Account.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Create_Account.ImageOptions.SvgImage")));
            this.Create_Account.Location = new System.Drawing.Point(382, 184);
            this.Create_Account.Name = "Create_Account";
            this.Create_Account.Size = new System.Drawing.Size(229, 29);
            this.Create_Account.TabIndex = 6;
            this.Create_Account.Text = "Add New a Account";
            // 
            // Picture_login
            // 
            this.Picture_login.Location = new System.Drawing.Point(2, 1);
            this.Picture_login.Name = "Picture_login";
            this.Picture_login.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Picture_login.Properties.InitialImageOptions.Image")));
            this.Picture_login.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Picture_login.Size = new System.Drawing.Size(242, 324);
            this.Picture_login.TabIndex = 7;
            // 
            // Login_Account
            // 
            this.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 326);
            this.Controls.Add(this.Picture_login);
            this.Controls.Add(this.Create_Account);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Name = "Login_Account";
            this.Text = "Login Account";
            ((System.ComponentModel.ISupportInitialize)(this.User_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_login.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Username_label;
        private DevExpress.XtraEditors.LabelControl Password_label;
        private DevExpress.XtraEditors.TextEdit User_text;
        private DevExpress.XtraEditors.TextEdit Password_text;
        private DevExpress.XtraEditors.SimpleButton Login_bt;
        private DevExpress.XtraEditors.SimpleButton Cancel_bt;
        private DevExpress.XtraEditors.SimpleButton Create_Account;
        private DevExpress.XtraEditors.PictureEdit Picture_login;
    }
}