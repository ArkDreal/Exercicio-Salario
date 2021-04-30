using System;

namespace Exercício_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
             Console . WriteLine ( " Qual é o seu salário atual? " );
            float  salarioAtual  =  float . Parse ( Console . ReadLine ());

            if ( salarioAtual  <  500 ) {
               float  salarioPorcentagem  = ( salarioAtual  /  100 ) *  30 ;
               float  salarioCorreto  =  salarioAtual  +  salarioPorcentagem ;
               Console . WriteLine ( " Seu salário corrigido é: "  +  salarioCorreto );
            }

            else {
                Console . WriteLine ( " Você não tem direito ao benefício " );
            }
        }
    }
}
