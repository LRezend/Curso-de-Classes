using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace teste
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null &&nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        
        public double AdicionarProdutos(int quantidade)
        {
            return _quantidade = quantidade;
        }

        public double RemoverProdutos(int quantidade)
        {
            return _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ",$ "
                + _preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + "Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
