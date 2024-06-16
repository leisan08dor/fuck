namespace demo1
{
    partial class Avtorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_avroriz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_input = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_avroriz
            // 
            this.lb_avroriz.AutoSize = true;
            this.lb_avroriz.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_avroriz.Location = new System.Drawing.Point(147, 62);
            this.lb_avroriz.Name = "lb_avroriz";
            this.lb_avroriz.Size = new System.Drawing.Size(169, 55);
            this.lb_avroriz.TabIndex = 0;
            this.lb_avroriz.Text = "Авторизация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_login.Location = new System.Drawing.Point(136, 166);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(189, 47);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_password.Location = new System.Drawing.Point(136, 230);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(189, 47);
            this.tb_password.TabIndex = 4;
            // 
            // bt_input
            // 
            this.bt_input.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_input.Location = new System.Drawing.Point(178, 397);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(113, 49);
            this.bt_input.TabIndex = 5;
            this.bt_input.Text = "Войти";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::demo1.Properties.Resources.Лопушок1;
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_avroriz);
            this.Name = "Avtorization";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_avroriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

