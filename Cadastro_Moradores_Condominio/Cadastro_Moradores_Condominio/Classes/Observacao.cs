using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Moradores_Condominio
{
    public class Observacao
    {
        private string observacao = "";

        public string Texto
        {
            get { return this.observacao; }
            set { this.observacao = value; }
        }
    }
}
