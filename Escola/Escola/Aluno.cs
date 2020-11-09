using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    class Aluno
    {
        String Nome, Email, Cidade;
        Boolean Status;
        public Aluno()
        {
            this.Status = true;
        }
        public Aluno(String Nome, String Email, String Cidade) : this()
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Cidade = Cidade;
        }
    }
}
