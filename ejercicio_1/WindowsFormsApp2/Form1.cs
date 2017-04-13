using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listNumbers = new List<int>();
            List<string> listCharacters = new List<string>();
            string[] splitCharacters = textBox1.Text.Select(c => c.ToString()).ToArray();
            int num;
            for (int i = 0; i < splitCharacters.Length; i++)
            {
                if (int.TryParse(splitCharacters[i], out num)) {
                    listNumbers.Add(num);
                } else {
                    listCharacters.Add(splitCharacters[i]);
                }
            }
            //numbers.Text = String.Join(", ", listNumbers.ToArray());
            numbers.Text = String.Join(", ", bubbleSort(listNumbers).ToArray());
            characters.Text = String.Join(", ", listCharacters.OrderBy(q => q).ToArray());
        }

        private List<int> bubbleSort(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < list.Count() - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }

    }
}
