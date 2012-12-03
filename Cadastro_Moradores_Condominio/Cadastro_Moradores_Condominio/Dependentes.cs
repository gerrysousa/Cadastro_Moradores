using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Moradores_Condominio
{
    public class Dependentes
    {
        private string[] vetDependentes = new string[6];
        private string[] vetParentesco = new string[6];

        public void SetDependente(int index, string dependente)
        {
            vetDependentes[index] = dependente;
        }

        public void SetParentesco(int index, string parentesco)
        {
            vetParentesco[index] = parentesco;
        }

        public string GetDependente(int index)
        {
            return this.vetDependentes[index];
        }

        public string GetParentesco(int index)
        {
            return this.vetParentesco[index];
        }

    }
}
