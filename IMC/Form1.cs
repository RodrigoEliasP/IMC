using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Atleta atleta = new Atleta();
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                atleta.Nome = txt_Nome.Text;
                atleta.Idade = int.Parse(txt_Idade.Text);
                atleta.Altura = double.Parse(txt_Altura.Text);
                atleta.Peso = double.Parse(txt_Peso.Text);
                lbl_Resultado.Text = "Seu IMC é: " + atleta.CalculaIMC().ToString();
            }catch(FormatException error)
            {
                MessageBox.Show("algum dos campos está com dados incorretos, erro:" + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
