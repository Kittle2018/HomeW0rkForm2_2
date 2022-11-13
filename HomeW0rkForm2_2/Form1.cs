using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW0rkForm2_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += StartGame;
        }

        private void StartGame(object sender, EventArgs e)
        {
            DialogResult result;
            int numDialog = 1;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество запросов {numDialog}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    result = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;
            }
        }
    }
}
