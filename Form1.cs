using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorarProcessos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void monitoraProcesso(string processo)
        {
            Process[] processos = Process.GetProcessesByName(processo);

            if (processos.Length == 0)
            {
                MessageBox.Show(processo + " NÃO está sendo executado");
            }
            else
            {
                MessageBox.Show(processo + " está sendo executado");
            }
        }

        private void matarProcesso(string processo)
        {
            Process[] processos = Process.GetProcessesByName(processo);
            foreach (var p in processos)
                p.Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processo = txtBoxProcesso.Text.ToUpper();
            monitoraProcesso(processo);
        }

        private void btnMatar_Click(object sender, EventArgs e)
        {
            string processo = txtBoxProcesso.Text.ToUpper();
            matarProcesso(processo);


        }
    }
}
