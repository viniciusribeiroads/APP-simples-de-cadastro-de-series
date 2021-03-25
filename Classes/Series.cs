using System;
using System.Collections.Generic;

namespace DIO.Series
{
    public class Series : EntidadeBase

    {
        
        // ATRIBUTOS
        private Genero Genero { get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get ; set ;}

        private bool Excluido {get; set;}
    

        //METODOS
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            //Enviroment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}