namespace documnets_demo
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eyesClose = new System.Windows.Forms.PictureBox();
            this.eyesOpen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyesClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(1)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EnterBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 796);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.eyesClose);
            this.panel2.Controls.Add(this.eyesOpen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PassBox);
            this.panel2.Controls.Add(this.LoginBox);
            this.panel2.Location = new System.Drawing.Point(104, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 377);
            this.panel2.TabIndex = 0;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(95, 79);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(378, 39);
            this.LoginBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(95, 268);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(378, 39);
            this.PassBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(231, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(220, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // EnterBut
            // 
            this.EnterBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(71)))));
            this.EnterBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterBut.FlatAppearance.BorderSize = 0;
            this.EnterBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(193)))));
            this.EnterBut.Location = new System.Drawing.Point(221, 668);
            this.EnterBut.Name = "EnterBut";
            this.EnterBut.Size = new System.Drawing.Size(335, 70);
            this.EnterBut.TabIndex = 1;
            this.EnterBut.Text = "Войти";
            this.EnterBut.UseVisualStyleBackColor = false;
            this.EnterBut.Click += new System.EventHandler(this.EnterBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(147, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 82);
            this.label3.TabIndex = 2;
            this.label3.Text = "Авторизация";
            // 
            // eyesClose
            // 
            this.eyesClose.BackColor = System.Drawing.SystemColors.Window;
            this.eyesClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyesClose.Image = global::documnets_demo.Properties.Resources.скрыть;
            this.eyesClose.Location = new System.Drawing.Point(432, 268);
            this.eyesClose.Name = "eyesClose";
            this.eyesClose.Size = new System.Drawing.Size(41, 39);
            this.eyesClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyesClose.TabIndex = 5;
            this.eyesClose.TabStop = false;
            this.eyesClose.Click += new System.EventHandler(this.eyesClose_Click);
            // 
            // eyesOpen
            // 
            this.eyesOpen.BackColor = System.Drawing.SystemColors.Window;
            this.eyesOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyesOpen.Image = global::documnets_demo.Properties.Resources.показать;
            this.eyesOpen.Location = new System.Drawing.Point(432, 268);
            this.eyesOpen.Name = "eyesOpen";
            this.eyesOpen.Size = new System.Drawing.Size(41, 39);
            this.eyesOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyesOpen.TabIndex = 4;
            this.eyesOpen.TabStop = false;
            this.eyesOpen.Click += new System.EventHandler(this.eyesOpen_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 796);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyesClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button EnterBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox eyesOpen;
        private System.Windows.Forms.PictureBox eyesClose;
    }
}