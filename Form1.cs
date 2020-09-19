using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeStack
{
    public partial class Form1 : Form
    {
        class Stack
        {
            public int Capacity;
            public int Pointer;
            public string[] Data;
            public Stack(int maxSize)
            {
                Capacity = maxSize;
                Data = new string[maxSize];
                Pointer = 0;
            }
            
            public void Push(string str)
            {
                Data[Pointer++] = str;
            }
            public string Pop()
            {
                return Data[--Pointer];
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Stack stack;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            if(tb_input.TextLength == 0)
            {
                MessageBox.Show("Строка пуста", "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stack.Push(tb_input.Text);
            lb_stack.Items.Clear();
            for(int i = 0; i < stack.Pointer; i++)
            {
                lb_stack.Items.Add(stack.Data[i]);
            }
            
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            var size = int.Parse(tb_size.Text);
            stack = new Stack(size);
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Pop());
            lb_stack.Items.Clear();
            for (int i = 0; i < stack.Pointer; i++)
            {
                lb_stack.Items.Add(stack.Data[i]);
            }
        }
    }
}
