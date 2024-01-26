using System.Windows.Forms;

namespace C__UI_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // for adding a new text/phrase
                string newText = textBox1.Text.Trim();

                // Change the selected item in the ListBox
                listBox1.Items[listBox1.SelectedIndex] = newText;

                // Clear text in the textbox
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();

            //for adding the word or phrase to the list
            if (!string.IsNullOrEmpty(text))
            {
                listBox1.Items.Add(text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //removing the selected word/text/phrase
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clearing the whole listbox
            listBox1.Items.Clear();
        }
    }

}
