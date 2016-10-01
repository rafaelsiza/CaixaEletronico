using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();

            umaConta.numero = 1;
            umaConta.titular = "Rafael Siza";
            umaConta.saldo = 10000;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Marta Siza";
            outraConta.saldo = 100000;

            MessageBox.Show("O titular da conta é " + umaConta.titular);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            Conta mauricio = new Conta();

            guilherme.saldo = 1000;
            MessageBox.Show("Saldo do Guilherme antes do saque " + guilherme.saldo);

            guilherme.Saca(100);
            MessageBox.Show("Saldo do Guilherme depois do saque " + guilherme.saldo);


            guilherme.Deposita(500);
            MessageBox.Show("Saldo do Guilherme depois do depósito " + guilherme.saldo);


            guilherme.Transfere(50, mauricio);
            MessageBox.Show("Saldo do Mauricio depois da traferencia " + mauricio.saldo);

        }
    }
}
