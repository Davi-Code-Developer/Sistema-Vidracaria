using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema.Cadastro
{
    [Serializable]
    public class Produto
    {
        private string produto;
        private string comprimento;
        private double valor;
        private string espessura;
        private string altura;
        private string tipo;
        private string estilo;

        public string ProdutoNome { get => produto; set => produto = value; }
        public string Comprimento { get => comprimento; set => comprimento = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Espessura { get => espessura; set => espessura = value; }
        public string Altura { get => altura; set => altura = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estilo { get => estilo; set => estilo = value; }

        public Produto(string produto, string comprimento, double valor, string espessura, string altura, string tipo, string estilo)
        {
            this.ProdutoNome = produto;
            this.Comprimento = comprimento;
            this.Valor = valor;
            this.Espessura = espessura;
            this.Altura = altura;
            this.Tipo = tipo;
            this.Estilo = estilo;
        }
        public override string ToString()
        {
            return ProdutoNome + "," +
                valor + "," + 
                espessura + "," +
                comprimento + "," +
                altura + "," + 
                tipo + "," + 
                estilo;
        }
    }
}
