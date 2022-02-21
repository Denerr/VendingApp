using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            defineVal();
        }

        private void defineVal()
        {
            txtQuantidade.Text = "0";
            txtValUni.Text = "0";
            txtValTotal.Text = "0";
        }

        private void calcValTotal()
        {
            int quantidade;
            double valor_uni, resultado;

            quantidade = int.Parse(txtQuantidade.Text);
            valor_uni = Double.Parse(txtValUni.Text);

            resultado = valor_uni * quantidade;
            txtValTotal.Text = resultado.ToString();
        }
        
        private void verificarCampos()
        {
            if (txtQuantidade.Text == "" && txtValUni.Text == "")
            {
                MessageBox.Show("Preencha os campos Quantidade e/ou Valor Unitario!");
            }
            else if (txtQuantidade.Text != "" && txtValUni.Text == "")
            {
                txtValTotal.Text = "0";
            }
            else if (txtValUni.Text != "" && txtQuantidade.Text == "")
            {
                txtValTotal.Text = txtValUni.Text;
            }
            else
            {
                calcValTotal();
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtValTotal.Text == "0")
            {
                MessageBox.Show("Valor total é invalido!");
            }
            else
            {
                string mensagem, titulo;
                mensagem = "Deseja cadastrar essa venda?";
                titulo = "Cadastrar Venda";
                var resul = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);

                if (resul == DialogResult.Yes)
                {
                    MessageBox.Show("Venda Cadastrada!");
                    this.Close();
                }
                else
                {
                    //Não cadastra a Venda
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            cmbProduto.SelectedItem = null;
            txtQuantidade.Text = "0";
            txtValUni.Text = "0";
            txtValTotal.Text = "0";
            cmbPagamento.SelectedItem = null;

            MessageBox.Show("Campos Limpos!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensagem, titulo;
            mensagem = "Deseja cancelar a venda?";
            titulo = "Cancelar Venda";
            var resul = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Faz nada;
            }
        }

        private void txtValUni_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }
    }
}
