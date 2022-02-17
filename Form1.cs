using System;
using System.Windows.Forms;

namespace KPpoOS
{
    public partial class Form1 : Form
    {
        string[] groupsKSI = { "29", "30", "31", "32", "33" };
        string[] groupsITI = { "35", "36" };

        int ksiCount = 0;
        int itiCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(comboBox1.Text);

            if (comboBox1.Text == "КСИ") comboBox3.DataSource = groupsKSI;
            if (comboBox1.Text == "ИТИ") comboBox3.DataSource = groupsITI;

            lvi.SubItems.Add(comboBox3.Text);

            lvi.SubItems.Add(comboBox2.Text);

            if (radioButton1.Checked)
                lvi.SubItems.Add("Мъж");
            if (radioButton2.Checked) 
                lvi.SubItems.Add("Жена");

            listView1.Items.Add(lvi);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "КСИ")
            {
                comboBox3.Visible = true;
                comboBox3.DataSource = groupsKSI;
            }
            else
            {
                comboBox3.Visible = true;
                comboBox3.DataSource = groupsITI;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ksiCount = 0;
            itiCount = 0;
            foreach(ListViewItem lvi in listView1.Items)
            {
                if(lvi.SubItems[3].Text == "КСИ")
                {
                    ksiCount++;
                }
                if (lvi.SubItems[3].Text == "ИТИ")
                {
                    itiCount++;
                }
            }
            label7.Text = "броят студенти във ФКСТ е " + (ksiCount+itiCount);
            label8.Text = "в КСИ са " + ksiCount;
            label9.Text = "в ИТИ са " + itiCount;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
