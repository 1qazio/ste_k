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
            this.tb_size = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lb_stack = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_size);
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер стека";
            // 
            // tb_size
            // 
            this.tb_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_size.BackColor = System.Drawing.SystemColors.Info;
            this.tb_size.Location = new System.Drawing.Point(7, 19);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(654, 20);
            this.tb_size.TabIndex = 1;
            // 
            // btn_set
            // 
            this.btn_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Location = new System.Drawing.Point(7, 48);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(654, 23);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Задать";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.BackColor = System.Drawing.SystemColors.Info;
            this.tb_input.Location = new System.Drawing.Point(6, 19);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(649, 124);
            this.tb_input.TabIndex = 0;
            // 
            // btn_add_item
            // 
            this.btn_add_item.AutoSize = true;
            this.btn_add_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_item.Location = new System.Drawing.Point(6, 149);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(67, 23);
            this.btn_add_item.TabIndex = 1;
            this.btn_add_item.Text = "Добавить";
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_add_item);
            this.groupBox2.Controls.Add(this.tb_input);
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.lb_stack);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 480);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стэк";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(411, 178);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 231);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(499, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "найти мин";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(319, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "найти мах";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Location = new System.Drawing.Point(6, 440);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(307, 27);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Удалить";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lb_stack
            // 
            this.lb_stack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_stack.BackColor = System.Drawing.SystemColors.Info;
            this.lb_stack.FormattingEnabled = true;
            this.lb_stack.Location = new System.Drawing.Point(7, 178);
            this.lb_stack.Name = "lb_stack";
            this.lb_stack.Size = new System.Drawing.Size(397, 225);
            this.lb_stack.TabIndex = 0;
            this.lb_stack.SelectedIndexChanged += new System.EventHandler(this.lb_stack_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(667, 597);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

