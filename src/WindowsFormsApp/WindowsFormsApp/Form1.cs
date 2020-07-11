using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
            labelX.Visible = false;
            labelY.Visible = false;
            numericUpDownY.Visible = false;
            numericUpDownХ.Visible = false;
            buttonGo.Visible = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialogSite.ShowDialog()== DialogResult.OK)
            {
                path = openFileDialogSite.FileName;
            }
            webBrowser.Navigate(new Uri(path));
            labelX.Visible = true;
            labelY.Visible = true;
            numericUpDownY.Visible = true;
            numericUpDownХ.Visible = true;
            buttonGo.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            double x, y = 0;
            x = (double)numericUpDownХ.Value;
            y = (double)numericUpDownY.Value;
            if (path == "C:\\Users\\User\\Desktop\\Ekzamen\\web\\web.html")
            {
                if (x + y > 5 && x + y < 11 && x - y > -3 && x - y < 3)
                {
                    MessageBox.Show("Точка внутри ромба", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка внутри ромба";
                }
                else if ((y == x + 3 || y == x - 3 || y == -x + 5 || y == -x + 11) && x >= 1 && x <= 7 && y >= 1 && y <= 7)
                {
                    MessageBox.Show("Точка на границе ромба", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка на границе ромба";
                }
                else
                {
                    MessageBox.Show("Точка вне ромба", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка вне ромба";
                }
            }
            else
            {   
                if((y == 0 && x>-1 && x<1) || (y>=0 && y*y+x*x == 1) || (y== x * x))
                {
                    MessageBox.Show("Точка на границе фигуры", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка на границе фигуры";
                }
                else if(((y>0) && (y*y+x*x<1)) || (y> x * x))
                {
                    MessageBox.Show("Точка внутри фигуры", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка внутри фигуры";
                }
                else
                {
                    MessageBox.Show("Точка вне фигуры", "Анализ", MessageBoxButtons.OK);
                    toolStripStatusLabeStatus.Text = "Точка вне фигуры";
                }
            } 
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ухинова Тамара, ПКсп-117, Автоматизация расчетов", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
