using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AED3
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            StreamReader rd = new StreamReader(@".\datatran.csv", Encoding.Default, true);

            string linha = null;
            string[] linhaseparada = null;
            List<Object> linhas = new List<Object>();

            // ler o conteudo da linha e add na list 
            
            while ((linha = rd.ReadLine()) != null)
            {
                linhaseparada = linha.Split(',');
               
                    
                foreach (var item in linhaseparada)
                {
                    linhas.Add(item);
                }
                
            
            
                
            }
            for (int i = 1; i < 50; i++)
            {
                IEnumerable<string> query =
                    from line in linhaseparada
                    let x = line.Split(';')
                    orderby x[2]
                    select line;
                Console.WriteLine(linhas[i]);
            }

            for (int i = 1; i < 50; i++)
            {
                if(linhas[i]=="Nublado")
                {
                    Console.WriteLine(linhas[i]);
                }
                else
                {
                    break;
                }
                //Console.WriteLine(linhas[2]=="Nublado");
            }

        }
    }
}
            /*Stopwatch stopwatch = new Stopwatch();
            Arquivo arq = new Arquivo();

            string datatran = @".\datatran.csv";

            stopwatch.Start();
            Console.WriteLine("Carregando..");
            int[] bIL = arq.BuscaIlesos(datatran, 1);
            float[] bMo = arq.BuscaMortos(datatran, 1);
            string[] bCL = arq.BuscaClima(datatran, 1);
            stopwatch.Stop();
            Console.WriteLine("Tempo total | " + stopwatch.Elapsed + " segundos!");

        } 
    }
}

          /*  string[] scores = System.IO.File.ReadAllLines(@".\datatran.csv");
            //int sortField = 500000;

            /*Console.WriteLine("Sorted highest to lowest by field [{0}]:", sortField);
            foreach (string str in RunQuery(scores, sortField))
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            static IEnumerable<string> RunQuery(IEnumerable<string> source, int num)
            {
                // Split the string and sort on field[num]  
                var scoreQuery = from line in source
                                 let fields = line.Split(',')
                                 orderby fields[num] 
                                 select line;

                return scoreQuery;
            }
            
            IEnumerable<string> query =
            from line in scores
            let x = line.Split(';')
            orderby x[2]
            select x[2] + ", " + (x[1] + " " + x[0]);


            Console.WriteLine(query.ToString());
            Console.ReadKey();
        }
    }
}
          */