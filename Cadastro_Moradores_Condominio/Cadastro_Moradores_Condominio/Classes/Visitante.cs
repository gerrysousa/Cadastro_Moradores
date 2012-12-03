using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_Moradores_Condominio
{
    public class Visitante
    {
        private string[] vetVisitantes = new string[6];
        private string[] vetParentesco = new string[6];

        public void SetVisitante(int index, string dependente)
        {
            vetVisitantes[index] = dependente;
        }

        public void SetParentesco(int index, string parentesco)
        {
            vetParentesco[index] = parentesco;
        }

        public string GetVisitante(int index)
        {
            return this.vetVisitantes[index];
        }

        public string GetParentesco(int index)
        {
            return this.vetParentesco[index];
        }
    }
}
