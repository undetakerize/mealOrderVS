using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addIF(){
            checkedListBox1.Items.Add("Database");
            checkedListBox1.Items.Add("IT");
            checkedListBox1.Items.Add("Interface");
        }
        public void addManajemen()
        {
            checkedListBox1.Items.Add("Administrasi");
            checkedListBox1.Items.Add("Perpajakan");
            checkedListBox1.Items.Add("MPL");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "IF")
            {
                addIF();


            } if (comboBox1.SelectedItem == "Manajemen")
            {
                addManajemen();

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBox1.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int jumlah = 0;
            if ((textBox1.Text == "") || (comboBox1.Text==""))
            {
                MessageBox.Show("Nama atau jurusan tidak boleh kosong");
            }else{
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                jumlah = listBox1.Items.Count+1;
            }
            String title = "Succes";
            String jumlah2 = jumlah.ToString();
            MessageBox.Show("Nama : "+textBox1.Text+"\r\n"+"Jurusan: "+comboBox1.Text+"\r\n"+"Anda Mengambil: "+jumlah2+" Mata Kuliah",title);
        }
    }
  }
}
