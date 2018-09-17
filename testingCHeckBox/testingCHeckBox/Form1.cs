using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingCHeckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pre;
        public class Boxes
        {
            public bool box1;
            public bool box2;
            public bool box3;
            public bool box4;
            public bool box5;
            public bool box6;
            public bool box7;
            public bool box8;
            public int index;
        };

        List<Boxes> BoxList = new List<Boxes>();

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Объект 1");
            comboBox1.Items.Add("Объект 2");
            comboBox1.Items.Add("Объект 3");
            comboBox1.Items.Add("Объект 4");
            comboBox1.Items.Add("Объект 5");
            comboBox1.Items.Add("Объект 6");
            comboBox1.Items.Add("Объект 7");
            comboBox1.Items.Add("Объект 8");
            comboBox1.Items.Add("Объект 9");

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                var bx = new Boxes() { index = i };

                BoxList.Add(bx);
            }



        }

        private void Clone()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Объект " + comboBox1.SelectedIndex + 1.ToString();

            int i = comboBox1.SelectedIndex;


            BoxList[pre].box1 = checkBox1.Checked;
            BoxList[pre].box2 = checkBox2.Checked;
            BoxList[pre].box3 = checkBox3.Checked;
            BoxList[pre].box4 = checkBox4.Checked;
            BoxList[pre].box5 = checkBox5.Checked;
            BoxList[pre].box6 = checkBox6.Checked;
            BoxList[pre].box7 = checkBox7.Checked;
            BoxList[pre].box8 = checkBox8.Checked;

            /*BoxList[pre].box1 = checkedListBox1.GetItemChecked(0);
            BoxList[pre].box2 = checkedListBox1.GetItemChecked(1);
            BoxList[pre].box3 = checkedListBox1.GetItemChecked(2);
            BoxList[pre].box4 = checkedListBox1.GetItemChecked(3);
            BoxList[pre].box5 = checkedListBox1.GetItemChecked(4);
            BoxList[pre].box6 = checkedListBox1.GetItemChecked(5);
            BoxList[pre].box7 = checkedListBox1.GetItemChecked(6);
            BoxList[pre].box8 = checkedListBox1.GetItemChecked(7);*/

           /* checkedListBox1.SetItemChecked(0, BoxList[i].box1);
            checkedListBox1.SetItemChecked(1, BoxList[i].box2);
            checkedListBox1.SetItemChecked(2, BoxList[i].box3);
            checkedListBox1.SetItemChecked(3, BoxList[i].box4);
            checkedListBox1.SetItemChecked(4, BoxList[i].box5);
            checkedListBox1.SetItemChecked(5, BoxList[i].box6);
            checkedListBox1.SetItemChecked(6, BoxList[i].box7);
            checkedListBox1.SetItemChecked(7, BoxList[i].box8);*/

            

            checkBox1.Checked = BoxList[i].box1;
            checkBox2.Checked = BoxList[i].box2;
            checkBox3.Checked = BoxList[i].box3;
            checkBox4.Checked = BoxList[i].box4;
            checkBox5.Checked = BoxList[i].box5;
            checkBox6.Checked = BoxList[i].box6;
            checkBox7.Checked = BoxList[i].box7;
            checkBox8.Checked = BoxList[i].box8;

            pre = i;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;

            /*  BoxList[i].box1 = checkBox1.Checked;
              BoxList[i].box2 = checkBox2.Checked;
              BoxList[i].box3 = checkBox3.Checked;
              BoxList[i].box4 = checkBox4.Checked;
              BoxList[i].box5 = checkBox5.Checked;
              BoxList[i].box6 = checkBox6.Checked;
              BoxList[i].box7 = checkBox7.Checked;
              BoxList[i].box8 = checkBox8.Checked;*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Boxes bx in BoxList)
            {
              int i = comboBox1.SelectedIndex;

             /* BoxList[i].box1 = checkedListBox1.GetItemChecked(0);
              BoxList[i].box2 = checkedListBox1.GetItemChecked(1);
              BoxList[i].box3 = checkedListBox1.GetItemChecked(2);
              BoxList[i].box4 = checkedListBox1.GetItemChecked(3);
              BoxList[i].box5 = checkedListBox1.GetItemChecked(4);
              BoxList[i].box6 = checkedListBox1.GetItemChecked(5);
              BoxList[i].box7 = checkedListBox1.GetItemChecked(6);
              BoxList[i].box8 = checkedListBox1.GetItemChecked(7);*/

              BoxList[i].box1 = checkBox1.Checked;
              BoxList[i].box2 = checkBox2.Checked;
              BoxList[i].box3 = checkBox3.Checked;
              BoxList[i].box4 = checkBox4.Checked;
              BoxList[i].box5 = checkBox5.Checked;
              BoxList[i].box6 = checkBox6.Checked;
              BoxList[i].box7 = checkBox7.Checked;
              BoxList[i].box8 = checkBox8.Checked;

                textBox1.AppendText("Объект " + bx.index.ToString() + ":\n");
                textBox1.AppendText("Параметр 1: " + bx.box1.ToString() + ";\n");
                textBox1.AppendText("Параметр 2: " + bx.box2.ToString() + ";\n");
                textBox1.AppendText("Параметр 3: " + bx.box3.ToString() + ";\n");
                textBox1.AppendText("Параметр 4: " + bx.box4.ToString() + ";\n");
                textBox1.AppendText("Параметр 5: " + bx.box5.ToString() + ";\n");
                textBox1.AppendText("Параметр 6: " + bx.box6.ToString() + ";\n");
                textBox1.AppendText("Параметр 7: " + bx.box7.ToString() + ";\n");
                textBox1.AppendText("Параметр 8: " + bx.box8.ToString() + ";\n");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Boxes bs in BoxList)
            {
               /* bs.box1 = checkedListBox1.GetItemChecked(0);
                bs.box2 = checkedListBox1.GetItemChecked(1);
                bs.box3 = checkedListBox1.GetItemChecked(2);
                bs.box4 = checkedListBox1.GetItemChecked(3);
                bs.box5 = checkedListBox1.GetItemChecked(4);
                bs.box6 = checkedListBox1.GetItemChecked(5);
                bs.box7 = checkedListBox1.GetItemChecked(6);
                bs.box8 = checkedListBox1.GetItemChecked(7);*/
                bs.box1 = checkBox1.Checked;
                bs.box2 = checkBox2.Checked;
                bs.box3 = checkBox3.Checked;
                bs.box4 = checkBox4.Checked;
                bs.box5 = checkBox5.Checked;
                bs.box6 = checkBox6.Checked;
                bs.box7 = checkBox7.Checked;
                bs.box8 = checkBox8.Checked;

            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)   // это плохая идея.
        {
            /*  int i = comboBox1.SelectedIndex;

              BoxList[i].box1 = checkedListBox1.GetItemChecked(0);
              BoxList[i].box2 = checkedListBox1.GetItemChecked(1);
              BoxList[i].box3 = checkedListBox1.GetItemChecked(2);
              BoxList[i].box4 = checkedListBox1.GetItemChecked(3);
              BoxList[i].box5 = checkedListBox1.GetItemChecked(4);
              BoxList[i].box6 = checkedListBox1.GetItemChecked(5);
              BoxList[i].box7 = checkedListBox1.GetItemChecked(6);
              BoxList[i].box8 = checkedListBox1.GetItemChecked(7);*/


            // попробовать производить запись по изменению листа и по кнопке вывести соответственно (какой лист выбран, тот и сохраняем.)



        }
    }
}
