using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //login
        //List<string> users = new List<string>();
        //List<string> password = new List<string>();
        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter user name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("please enter password first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (UserManager.IsValidUser(textBox1.Text, textBox2.Text) == true)
            {
                Form2 text_editor = new Form2();
                text_editor.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The username and/or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserManager.Load();

        }
        //exit
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //new user
        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 new_users = new Form3();
            new_users.Show();
            this.Hide();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
