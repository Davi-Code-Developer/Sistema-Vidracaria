using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Cadastro
{
    class Item
    {
        private string nome;
        private double valor;

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
