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
    public partial class Form2 : Form
    {
        string path = "";
        bool text = false;
        public Form2()
        {
            InitializeComponent();
        }

        //form
        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "User Name:" + UserManager.curUsername;
            if(UserManager.curUsertype == "Edit")
            {
                richTextBox1.Enabled = true;
            }
            else
            {
                richTextBox1.Enabled = false;
            }
        }

        //new
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            path = "";
        }

        //open
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open a file";
            openFileDialog1.Filter = "Text Files (*.rtf)|*.rtf| All Files(*.*) | *.*";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                try
                {
                    StreamReader fileOpen = new StreamReader(path);
                    String lines = fileOpen.ReadToEnd();
                    fileOpen.Close();
                    richTextBox1.Text = lines;
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error opening file: " + ioe.Message);
                }
                MessageBox.Show("The File Selected was:" + path);

            }
        }

        //save
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "Text Files(*.rtf) | *.txt | All Files(*.*) | *.*";
            savefiledialog1.Title = "Save File";

            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(savefiledialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                MessageBox.Show("The file is saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //save as
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.rtf) | *.rtf | All Files(*.*) | *.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw1 = new StreamWriter(sfd.FileName);
                sw1.WriteLine(richTextBox1.Text);
                sw1.Close();
                MessageBox.Show("The file is saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        //logout
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        //cut
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //copy
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //paste
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //bold
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont,oldFont.Style | FontStyle.Bold);
            }

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }
        //italic
        private void ItalicStripButton3_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }
        //underline
        private void UnderlineStripButton4_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vession 1.0.0.1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void ToolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Font oldFont, newFont;
                oldFont = richTextBox1.SelectionFont;
                newFont = new Font(oldFont.Name, (float)Convert.ToDouble(toolStripComboBox1.Text.ToString()));
                richTextBox1.SelectionFont = newFont;
                richTextBox1.Focus();
            }
            catch (Exception) { }
        }
        // new button
        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            path = "";
        }
        //open button
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open a file";
            openFileDialog1.Filter = "Text Files (*.rtf)|*.rtf| All Files(*.*) | *.*";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                try
                {
                    StreamReader fileOpen = new StreamReader(path);
                    String lines = fileOpen.ReadToEnd();
                    fileOpen.Close();
                    richTextBox1.Text = lines;
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error opening file: " + ioe.Message);
                }
                MessageBox.Show("The File Selected was:" + path);

            }
        }
        //save button
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "Text Files(*.rtf) | *.txt | All Files(*.*) | *.*";
            savefiledialog1.Title = "Save File";

            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(savefiledialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                MessageBox.Show("The file is saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //save as button
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.rtf) | *.rtf | All Files(*.*) | *.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw1 = new StreamWriter(sfd.FileName);
                sw1.WriteLine(richTextBox1.Text);
                sw1.Close();
                MessageBox.Show("The file is saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        
    }
}
