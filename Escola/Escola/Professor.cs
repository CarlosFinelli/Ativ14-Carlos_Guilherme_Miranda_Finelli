using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Professor
    {
        String Nome, Sobrenome;
        int Telefone;
        Boolean Oculos;

        public Professor()
        {
            this.Oculos = true;
        }
        public Professor(String Nome, String Sobrenome, int Telefone) : this()
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Telefone = Telefone;
        }

        public int IncluiTelefone()
        {
            return Telefone;
        }

        public void AtualizaTelefone(int telefone)
        {
            this.Telefone = telefone;
        }
    }
}
