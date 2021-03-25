using System;

namespace Separador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite números e letras misturados");
            char[] geral_coleta = new char[8];
            char[] armazena_nummero = new char[8];
            char[] armazena_latra = new char[8];
            char[] ordena_letra = new char[8];
            char[] ordena_numero = new char[8];
            char[] compara_numero = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] compara_letra = new char[26] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O',
                'P','Q','R','S','T','U','V','X','W','Y','Z'};
            int cont_progressivo = 0;

            for (int i = 0; i < geral_coleta.Length; i++)
            {
               

                geral_coleta[i] = Console.ReadKey().KeyChar;
                for (int j = 0; j < compara_letra.Length; j++)
                {
                   
                   
                    
                        if (geral_coleta[i] == compara_letra[j])
                        {
                            armazena_latra[i] = compara_letra[j];

                            ordena_letra[cont_progressivo] = armazena_latra[i];
                            cont_progressivo += 1;
                        }
                }
            }
            Console.WriteLine("---------");
            Console.WriteLine("Os números e letras foram separados");
            for (int i = 0; i < geral_coleta.Length; i++)
            {
               
               
                for (int k=0;k<compara_numero.Length;k++)
                {
                    if (geral_coleta[i]==compara_numero[k])
                    {
                        armazena_nummero[i] = compara_numero[k];
                        ordena_numero[cont_progressivo] = armazena_nummero[i];
                        cont_progressivo += 1;
                    }
                }
                Console.Write(ordena_letra[i]);
              

            }
            
            for (int i = 0; i < geral_coleta.Length; i++)
            {
                Console.Write(armazena_nummero[i]);
            }
            Console.WriteLine();
            Console.ReadKey();









        }
    }
}
