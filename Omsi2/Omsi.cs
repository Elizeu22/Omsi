using System;
using System.Collections.Generic;
using System.IO;

namespace Omsi2
{
    class Omsi
    {
        static void Main(string[] args)
        {

            string[] diretorio = Directory.GetFiles(@"Caminho do arquivo");
     
            foreach (string dir in diretorio)
            {

                if (dir.Contains("arquivo"))
                {
                  
                    System.IO.File.Delete(dir);

                }
                else
                {
                    break;
                }


            }

        }
    }
}
