using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioOnline
{
    class Operaciones
    {

        bool parOImpar;
        int numeroAEvaluar;
        private void EvaluarParoImpar(int num)
        {
            this.parOImpar = (num % 2 == 0);
            this.numeroAEvaluar = num;
            //return this.parOImpar;
        }

        public string entregarResultado(int num)
        {

            this.EvaluarParoImpar(num);
            if (this.parOImpar)
            {
                
                return $"El número {Convert.ToString(this.numeroAEvaluar)} es par";
            }
            else
            {
                return $"El número {Convert.ToString(this.numeroAEvaluar)} es impar";
            }
        }


    }
}
