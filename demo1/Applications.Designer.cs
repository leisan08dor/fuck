namespace demo1
{
    partial class Applications
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_input = new System.Windows.Forms.Button();
            this.lb_next = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_resultSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.tb_search.Location = new System.Drawing.Point(239, 12);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(188, 47);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // cb_sort
            // 
            this.cb_sort.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Location = new System.Drawing.Point(702, 15);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(180, 50);
            this.cb_sort.TabIndex = 5;
            this.cb_sort.Text = "Сортировка";
            this.cb_sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // cb_filter
            // 
            this.cb_filter.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(952, 13);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(214, 50);
            this.cb_filter.TabIndex = 6;
            this.cb_filter.Text = "Фильтрация";
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 398);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // bt_input
            // 
            this.bt_input.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.bt_input.Location = new System.Drawing.Point(952, 101);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(214, 49);
            this.bt_input.TabIndex = 8;
            this.bt_input.Text = "Добавить заявку";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // lb_next
            // 
            this.lb_next.AutoSize = true;
            this.lb_next.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_next.Location = new System.Drawing.Point(813, 515);
            this.lb_next.Name = "lb_next";
            this.lb_next.Size = new System.Drawing.Size(69, 42);
            this.lb_next.TabIndex = 9;
            this.lb_next.Text = "Вперед";
            this.lb_next.Click += new System.EventHandler(this.lb_next_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_back.Location = new System.Drawing.Point(725, 515);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(62, 42);
            this.lb_back.TabIndex = 10;
            this.lb_back.Text = "Назад";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.button1.Location = new System.Drawing.Point(952, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обновить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.lb_number.Location = new System.Drawing.Point(12, 15);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(192, 42);
            this.lb_number.TabIndex = 12;
            this.lb_number.Text = "Введите номер заявки: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.8F);
            this.label1.Location = new System.Drawing.Point(542, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дата заявки: ";
            // 
            // lb_resultSearch
            // 
            this.lb_resultSearch.AutoSize = true;
            this.lb_resultSearch.Location = new System.Drawing.Point(968, 336);
            this.lb_resultSearch.Name = "lb_resultSearch";
            this.lb_resultSearch.Size = new System.Drawing.Size(178, 16);
            this.lb_resultSearch.TabIndex = 0;
            this.lb_resultSearch.Text = "Соответствий не найдено";
            this.lb_resultSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 566);
            this.Controls.Add(this.lb_resultSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.lb_next);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.tb_search);
            this.Name = "Applications";
            this.Text = "Заявки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_FormClosed);
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.Label lb_next;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_resultSearch;
    }
}