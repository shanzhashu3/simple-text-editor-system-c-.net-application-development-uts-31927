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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        //submit
        private void Button1_Click(object sender, EventArgs e)
        {
            //information need be full
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                //password should be same
                if (textBox3.Text == textBox2.Text)
                {
                    //save information to file
                    try
                    {
                        StreamWriter sw = File.AppendText("login.txt");
                        sw.Write("\n" + textBox1.Text + "," + textBox3.Text + "," + comboBox1.Text + "," + textBox4.Text + "," +
                            textBox5.Text + "," + dateTimePicker1.Text);
                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("Users created successfully!!", "information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    catch (DirectoryNotFoundException ex) 
                    {
                        Directory.CreateDirectory("login.txt");
                        StreamWriter sw = File.AppendText("login.txt");
                        sw.WriteLine(textBox1.Text + "," + textBox3.Text + "," + comboBox1.Text + "," + textBox4.Text + "," +
                            textBox5.Text + "," + dateTimePicker1.Text);
                        sw.Flush();
                        sw.Close();

                        MessageBox.Show("Users created successfully!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("The password should be same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the information", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //cancel
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        //password
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //re enter password
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                label9.ForeColor = Color.Green;
                label9.Text = "password match";
            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Text = "the password not match!";

            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
