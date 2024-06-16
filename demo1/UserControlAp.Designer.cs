namespace demo1
{
    partial class UserControlAp
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_number = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_device = new System.Windows.Forms.Label();
            this.lb_type_problem = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_number.Location = new System.Drawing.Point(24, 22);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(128, 42);
            this.lb_number.TabIndex = 0;
            this.lb_number.Text = "Номер заявки: ";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_date.Location = new System.Drawing.Point(285, 22);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(68, 42);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "Дата: ";
            // 
            // lb_device
            // 
            this.lb_device.AutoSize = true;
            this.lb_device.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_device.Location = new System.Drawing.Point(24, 106);
            this.lb_device.Name = "lb_device";
            this.lb_device.Size = new System.Drawing.Size(130, 42);
            this.lb_device.TabIndex = 2;
            this.lb_device.Text = "Оборудование: ";
            // 
            // lb_type_problem
            // 
            this.lb_type_problem.AutoSize = true;
            this.lb_type_problem.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_type_problem.Location = new System.Drawing.Point(285, 106);
            this.lb_type_problem.Name = "lb_type_problem";
            this.lb_type_problem.Size = new System.Drawing.Size(128, 42);
            this.lb_type_problem.TabIndex = 3;
            this.lb_type_problem.Text = "Тип проблемы: ";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_status.Location = new System.Drawing.Point(553, 106);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(86, 42);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Статус: ";
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_delete.Location = new System.Drawing.Point(678, 22);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(123, 42);
            this.bt_delete.TabIndex = 5;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(655, 103);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(146, 50);
            this.cb_status.TabIndex = 7;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // UserControlAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_type_problem);
            this.Controls.Add(this.lb_device);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_number);
            this.Name = "UserControlAp";
            this.Size = new System.Drawing.Size(829, 189);
            this.Load += new System.EventHandler(this.UserControlAp_Load);
            this.Click += new System.EventHandler(this.UserControlAp_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_device;
        private System.Windows.Forms.Label lb_type_problem;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_status;
    }
}
