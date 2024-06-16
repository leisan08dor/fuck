namespace demo1
{
    partial class ApInfo
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.lb_client = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_desription = new System.Windows.Forms.Label();
            this.lb_type_problem = new System.Windows.Forms.Label();
            this.tb_device = new System.Windows.Forms.TextBox();
            this.lb_device = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lb_number = new System.Windows.Forms.Label();
            this.cb_executor = new System.Windows.Forms.ComboBox();
            this.lb_execute = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.lb_comm = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_type_problem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_cancel.Location = new System.Drawing.Point(876, 424);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(129, 49);
            this.bt_cancel.TabIndex = 27;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // tb_client
            // 
            this.tb_client.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_client.Location = new System.Drawing.Point(556, 164);
            this.tb_client.Name = "tb_client";
            this.tb_client.ReadOnly = true;
            this.tb_client.Size = new System.Drawing.Size(276, 47);
            this.tb_client.TabIndex = 24;
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_client.Location = new System.Drawing.Point(414, 167);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(81, 42);
            this.lb_client.TabIndex = 33;
            this.lb_client.Text = "Клиент:";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_description.Location = new System.Drawing.Point(167, 241);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(478, 132);
            this.tb_description.TabIndex = 23;
            // 
            // lb_desription
            // 
            this.lb_desription.AutoSize = true;
            this.lb_desription.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_desription.Location = new System.Drawing.Point(8, 246);
            this.lb_desription.Name = "lb_desription";
            this.lb_desription.Size = new System.Drawing.Size(95, 42);
            this.lb_desription.TabIndex = 32;
            this.lb_desription.Text = "Описание:";
            // 
            // lb_type_problem
            // 
            this.lb_type_problem.AutoSize = true;
            this.lb_type_problem.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_type_problem.Location = new System.Drawing.Point(849, 87);
            this.lb_type_problem.Name = "lb_type_problem";
            this.lb_type_problem.Size = new System.Drawing.Size(169, 42);
            this.lb_type_problem.TabIndex = 31;
            this.lb_type_problem.Text = "Тип неисправности:";
            // 
            // tb_device
            // 
            this.tb_device.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_device.Location = new System.Drawing.Point(167, 162);
            this.tb_device.Name = "tb_device";
            this.tb_device.ReadOnly = true;
            this.tb_device.Size = new System.Drawing.Size(189, 47);
            this.tb_device.TabIndex = 21;
            // 
            // lb_device
            // 
            this.lb_device.AutoSize = true;
            this.lb_device.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_device.Location = new System.Drawing.Point(8, 167);
            this.lb_device.Name = "lb_device";
            this.lb_device.Size = new System.Drawing.Size(126, 42);
            this.lb_device.TabIndex = 30;
            this.lb_device.Text = "Оборудование:";
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_date.Location = new System.Drawing.Point(556, 82);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(175, 47);
            this.tb_date.TabIndex = 20;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_date.Location = new System.Drawing.Point(414, 87);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(117, 42);
            this.lb_date.TabIndex = 29;
            this.lb_date.Text = "Дата заявки:";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_info.Location = new System.Drawing.Point(-1, 13);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(256, 55);
            this.lb_info.TabIndex = 28;
            this.lb_info.Text = "Информация по завке";
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_add.Location = new System.Drawing.Point(1037, 424);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(246, 49);
            this.bt_add.TabIndex = 26;
            this.bt_add.Text = "Сохранить изменения";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_number.Location = new System.Drawing.Point(167, 82);
            this.tb_number.Name = "tb_number";
            this.tb_number.ReadOnly = true;
            this.tb_number.Size = new System.Drawing.Size(189, 47);
            this.tb_number.TabIndex = 19;
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_number.Location = new System.Drawing.Point(8, 87);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(124, 42);
            this.lb_number.TabIndex = 25;
            this.lb_number.Text = "Номер заявки:";
            // 
            // cb_executor
            // 
            this.cb_executor.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_executor.FormattingEnabled = true;
            this.cb_executor.Location = new System.Drawing.Point(978, 159);
            this.cb_executor.Name = "cb_executor";
            this.cb_executor.Size = new System.Drawing.Size(305, 50);
            this.cb_executor.TabIndex = 34;
            // 
            // lb_execute
            // 
            this.lb_execute.AutoSize = true;
            this.lb_execute.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_execute.Location = new System.Drawing.Point(849, 159);
            this.lb_execute.Name = "lb_execute";
            this.lb_execute.Size = new System.Drawing.Size(123, 42);
            this.lb_execute.TabIndex = 35;
            this.lb_execute.Text = "Исполнитель:";
            // 
            // tb_comment
            // 
            this.tb_comment.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_comment.Location = new System.Drawing.Point(856, 246);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(427, 127);
            this.tb_comment.TabIndex = 36;
            // 
            // lb_comm
            // 
            this.lb_comm.AutoSize = true;
            this.lb_comm.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_comm.Location = new System.Drawing.Point(701, 249);
            this.lb_comm.Name = "lb_comm";
            this.lb_comm.Size = new System.Drawing.Size(131, 42);
            this.lb_comm.TabIndex = 37;
            this.lb_comm.Text = "Комментарий:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_status.Location = new System.Drawing.Point(25, 426);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(86, 42);
            this.lb_status.TabIndex = 38;
            this.lb_status.Text = "Статус: ";
            // 
            // tb_status
            // 
            this.tb_status.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_status.Location = new System.Drawing.Point(167, 424);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(189, 47);
            this.tb_status.TabIndex = 39;
            // 
            // tb_type_problem
            // 
            this.tb_type_problem.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_type_problem.Location = new System.Drawing.Point(1096, 82);
            this.tb_type_problem.Name = "tb_type_problem";
            this.tb_type_problem.ReadOnly = true;
            this.tb_type_problem.Size = new System.Drawing.Size(189, 47);
            this.tb_type_problem.TabIndex = 40;
            // 
            // ApInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 500);
            this.Controls.Add(this.tb_type_problem);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.lb_comm);
            this.Controls.Add(this.cb_executor);
            this.Controls.Add(this.lb_execute);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.tb_client);
            this.Controls.Add(this.lb_client);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_desription);
            this.Controls.Add(this.lb_type_problem);
            this.Controls.Add(this.tb_device);
            this.Controls.Add(this.lb_device);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lb_number);
            this.Name = "ApInfo";
            this.Text = "Информация по заявке";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApInfo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_desription;
        private System.Windows.Forms.Label lb_type_problem;
        private System.Windows.Forms.TextBox tb_device;
        private System.Windows.Forms.Label lb_device;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.ComboBox cb_executor;
        private System.Windows.Forms.Label lb_execute;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Label lb_comm;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_type_problem;
    }
}