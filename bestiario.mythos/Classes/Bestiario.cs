using System;
using bestiario.mythos.Enum;

namespace bestiario.mythos
{
    public class Bestiario : EntidadeBase
    {
        // Atributos
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private string Habilidade { get; set; }
        private Pistas Pistas { get; set; }
        private bool Excluido{ get; set; }

        // Metodo

        public Bestiario(int id, string nome, string descricao, string habilidade, Pistas pista)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Habilidade = habilidade;
            this.Pistas = pista;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Habilidade: " + this.Habilidade + Environment.NewLine;
            retorno += "Pista: " + this.Pistas + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public string retornaDescricao()
        {
            return this.Descricao;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}