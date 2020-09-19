namespace MakeStack
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_stack = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_size);
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер стека";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(6, 19);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(187, 20);
            this.tb_input.TabIndex = 0;
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(6, 45);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(187, 23);
            this.btn_add_item.TabIndex = 1;
            this.btn_add_item.Text = "Добавить";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_item);
            this.groupBox2.Controls.Add(this.tb_input);
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.lb_stack);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стэк";
            // 
            // lb_stack
            // 
            this.lb_stack.FormattingEnabled = true;
            this.lb_stack.Location = new System.Drawing.Point(7, 108);
            this.lb_stack.Name = "lb_stack";
            this.lb_stack.Size = new System.Drawing.Size(187, 160);
            this.lb_stack.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(6, 274);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(187, 23);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Удалить";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(7, 48);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(186, 23);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Задать";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(7, 19);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(187, 20);
            this.tb_size.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Реализация стека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox lb_stack;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Button btn_set;
    }
}

