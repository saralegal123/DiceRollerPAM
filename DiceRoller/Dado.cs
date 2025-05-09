using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Dado
    {
        //ModificadorDeAcesso Tipo Nome
        private string ladoSorteado;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public Dado()
        {
        }

        public string Roller()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                LadoSorteado = "1";
            }
            else
            {
                LadoSorteado = "coroa";
            }
            //   LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";

            return (LadoSorteado);
        }
}
