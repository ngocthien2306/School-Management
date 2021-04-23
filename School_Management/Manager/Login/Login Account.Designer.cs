
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Account));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Pass_tb = new DevExpress.XtraEditors.TextEdit();
            this.Sign_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Login_bt = new DevExpress.XtraEditors.SimpleButton();
            this.TipController = new DevExpress.Utils.ToolTipController(this.components);
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.User_tb = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_tb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Pass_tb
            // 
            this.Pass_tb.EditValue = "";
            this.Pass_tb.Location = new System.Drawing.Point(178, 136);
            this.Pass_tb.Name = "Pass_tb";
            this.Pass_tb.Properties.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Pass_tb.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_tb.Properties.Appearance.ForeColor = System.Drawing.Color.MistyRose;
            this.Pass_tb.Properties.Appearance.Options.UseBackColor = true;
            this.Pass_tb.Properties.Appearance.Options.UseFont = true;
            this.Pass_tb.Properties.Appearance.Options.UseForeColor = true;
            this.Pass_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Pass_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Pass_tb.Properties.ContextImageOptions.SvgImage")));
            this.Pass_tb.Size = new System.Drawing.Size(250, 36);
            this.Pass_tb.TabIndex = 1;
            this.Pass_tb.EditValueChanged += new System.EventHandler(this.Pass_tb_EditValueChanged);
            // 
            // Sign_bt
            // 
            this.Sign_bt.Location = new System.Drawing.Point(178, 246);
            this.Sign_bt.Name = "Sign_bt";
            this.Sign_bt.Size = new System.Drawing.Size(250, 38);
            this.Sign_bt.TabIndex = 2;
            this.Sign_bt.Text = "Created new a Account";
            // 
            // Login_bt
            // 
            this.Login_bt.Location = new System.Drawing.Point(318, 180);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(110, 38);
            this.Login_bt.TabIndex = 3;
            this.Login_bt.Text = "Login";
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SeaShell;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(178, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "User Login";
            // 
            // User_tb
            // 
            this.User_tb.EditValue = "";
            this.User_tb.Location = new System.Drawing.Point(177, 89);
            this.User_tb.Name = "User_tb";
            this.User_tb.Properties.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.User_tb.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_tb.Properties.Appearance.ForeColor = System.Drawing.Color.MistyRose;
            this.User_tb.Properties.Appearance.Options.UseBackColor = true;
            this.User_tb.Properties.Appearance.Options.UseFont = true;
            this.User_tb.Properties.Appearance.Options.UseForeColor = true;
            this.User_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.User_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("User_tb.Properties.ContextImageOptions.SvgImage")));
            this.User_tb.Size = new System.Drawing.Size(250, 36);
            this.User_tb.TabIndex = 0;
            this.User_tb.ToolTipController = this.TipController;
            this.User_tb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.User_tb.ToolTipTitle = "Username ";
            this.User_tb.EditValueChanged += new System.EventHandler(this.User_tb_EditValueChanged);
            // 
            // Login_Account
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(599, 315);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.User_tb);
            this.Controls.Add(this.Sign_bt);
            this.Controls.Add(this.Pass_tb);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Account";
            this.Text = "Login Account";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_tb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton Login_bt;
        private DevExpress.XtraEditors.SimpleButton Sign_bt;
        private DevExpress.XtraEditors.TextEdit Pass_tb;
        private DevExpress.Utils.ToolTipController TipController;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit User_tb;
    }
}