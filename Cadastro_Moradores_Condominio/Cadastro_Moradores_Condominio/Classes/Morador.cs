using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Moradores_Condominio
{
    public class Morador
    {
        public int ID { get; set; }
        
        public string Nome { get; set; }
        public string Predio { get; set; }
        public string Bloco { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Cpf { get; set; }        
        public string Apartamento { get; set; }
        public string DddResidencial { get; set; }
        public string DddComercial { get; set; }
        public string DddCelular1 { get; set; }
        public string DddCelular2 { get; set; }

        public Dependente Dependente { get; set; }
        public Visitante Visitante { get; set; }
        public Veiculo Veiculo { get; set; }
        public Locacao Locacao { get; set; }
        public Observacao Observacao { get; set; }
    }
}