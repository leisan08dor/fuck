namespace demo1
{
    partial class AddApplication
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
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lb_number = new System.Windows.Forms.Label();
            this.lb_newap = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.tb_device = new System.Windows.Forms.TextBox();
            this.lb_device = new System.Windows.Forms.Label();
            this.lb_type_problem = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_desription = new System.Windows.Forms.Label();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.lb_client = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.cb_type_problem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_add.Location = new System.Drawing.Point(685, 385);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(130, 49);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_number.Location = new System.Drawing.Point(180, 78);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(189, 47);
            this.tb_number.TabIndex = 1;
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_number.Location = new System.Drawing.Point(21, 83);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(124, 42);
            this.lb_number.TabIndex = 6;
            this.lb_number.Text = "Номер заявки:";
            // 
            // lb_newap
            // 
            this.lb_newap.AutoSize = true;
            this.lb_newap.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_newap.Location = new System.Drawing.Point(12, 9);
            this.lb_newap.Name = "lb_newap";
            this.lb_newap.Size = new System.Drawing.Size(166, 55);
            this.lb_newap.TabIndex = 9;
            this.lb_newap.Text = "Новая заявка";
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_date.Location = new System.Drawing.Point(626, 78);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(189, 47);
            this.tb_date.TabIndex = 2;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_date.Location = new System.Drawing.Point(427, 83);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(117, 42);
            this.lb_date.TabIndex = 10;
            this.lb_date.Text = "Дата заявки:";
            // 
            // tb_device
            // 
            this.tb_device.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_device.Location = new System.Drawing.Point(180, 158);
            this.tb_device.Name = "tb_device";
            this.tb_device.Size = new System.Drawing.Size(189, 47);
            this.tb_device.TabIndex = 3;
            // 
            // lb_device
            // 
            this.lb_device.AutoSize = true;
            this.lb_device.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_device.Location = new System.Drawing.Point(21, 163);
            this.lb_device.Name = "lb_device";
            this.lb_device.Size = new System.Drawing.Size(126, 42);
            this.lb_device.TabIndex = 12;
            this.lb_device.Text = "Оборудование:";
            // 
            // lb_type_problem
            // 
            this.lb_type_problem.AutoSize = true;
            this.lb_type_problem.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_type_problem.Location = new System.Drawing.Point(427, 165);
            this.lb_type_problem.Name = "lb_type_problem";
            this.lb_type_problem.Size = new System.Drawing.Size(169, 42);
            this.lb_type_problem.TabIndex = 14;
            this.lb_type_problem.Text = "Тип неисправности:";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_description.Location = new System.Drawing.Point(180, 237);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(189, 185);
            this.tb_description.TabIndex = 5;
            // 
            // lb_desription
            // 
            this.lb_desription.AutoSize = true;
            this.lb_desription.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_desription.Location = new System.Drawing.Point(21, 242);
            this.lb_desription.Name = "lb_desription";
            this.lb_desription.Size = new System.Drawing.Size(95, 42);
            this.lb_desription.TabIndex = 16;
            this.lb_desription.Text = "Описание:";
            // 
            // tb_client
            // 
            this.tb_client.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_client.Location = new System.Drawing.Point(626, 230);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(189, 47);
            this.tb_client.TabIndex = 6;
            // 
            // lb_client
            // 
            this.lb_client.AutoSize = true;
            this.lb_client.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_client.Location = new System.Drawing.Point(427, 233);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(81, 42);
            this.lb_client.TabIndex = 18;
            this.lb_client.Text = "Клиент:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_cancel.Location = new System.Drawing.Point(523, 385);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(129, 49);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // cb_type_problem
            // 
            this.cb_type_problem.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_type_problem.FormattingEnabled = true;
            this.cb_type_problem.Location = new System.Drawing.Point(628, 155);
            this.cb_type_problem.Name = "cb_type_problem";
            this.cb_type_problem.Size = new System.Drawing.Size(187, 50);
            this.cb_type_problem.TabIndex = 4;
            // 
            // AddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.cb_type_problem);
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
            this.Controls.Add(this.lb_newap);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lb_number);
            this.Name = "AddApplication";
            this.Text = "Новая заявка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddApplication_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label lb_newap;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.TextBox tb_device;
        private System.Windows.Forms.Label lb_device;
        private System.Windows.Forms.Label lb_type_problem;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_desription;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.Label lb_client;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.ComboBox cb_type_problem;
    }
}