using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1184037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKeyboard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar mouse";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar monitor";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar printer";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }
        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar scanner";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar scanner";
            }
        }

        private void tslKetGambar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}