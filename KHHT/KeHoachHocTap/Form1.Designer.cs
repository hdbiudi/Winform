namespace KeHoachHocTap
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label_UerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.label_UerName);
            this.panel1.Location = new System.Drawing.Point(71, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 49);
            this.panel1.TabIndex = 0;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(89, 12);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(263, 23);
            this.txt_UserName.TabIndex = 1;
            // 
            // label_UerName
            // 
            this.label_UerName.AutoSize = true;
            this.label_UerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_UerName.Location = new System.Drawing.Point(29, 12);
            this.label_UerName.Name = "label_UerName";
            this.label_UerName.Size = new System.Drawing.Size(69, 19);
            this.label_UerName.TabIndex = 0;
            this.label_UerName.Text = "MSSV : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txt_PassWord);
            this.panel2.Controls.Add(this.label_PassWord);
            this.panel2.Location = new System.Drawing.Point(71, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 49);
            this.panel2.TabIndex = 2;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(89, 12);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(263, 23);
            this.txt_PassWord.TabIndex = 1;
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_PassWord.Location = new System.Drawing.Point(3, 12);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(95, 19);
            this.label_PassWord.TabIndex = 0;
            this.label_PassWord.Text = "Mật Khẩu : ";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Teal;
            this.btn_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(160, 161);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 44);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Teal;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(307, 162);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 44);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KeHoachHocTap.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(539, 256);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public TextBox txt_UserName;
        private Label label_UerName;
        private Panel panel2;
        private TextBox txt_PassWord;
        public Label label_PassWord;
        private Button btn_Login;
        private Button btn_Exit;
    }
}