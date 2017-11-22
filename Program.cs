using System;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Curitiba");
            cidades.Add("Osasco");
            cidades.Add("Manaus");

            Console.WriteLine(cidades[1].ToUpper()); */



            /* List<Usuarios> us = new List<Usuarios>();
            Usuarios Lucas = new Usuarios(){Id=35,Login="lucas",Senha="12345"};
            Usuarios Tuanny = new Usuarios(){Id=10,Login="tuanny",Senha="12"};

            us.Add(Lucas);
            us.Add(Tuanny);
            
            Console.WriteLine(us[0].Login); */

            List<Produto> sacola = new List<Produto>();

            HigienePessoal sabonete = new HigienePessoal();
            sabonete.Id = 10;
            sabonete.Nome = "Dove";
            sabonete.NumeroMS = "123458";
            sabonete.Marca = "P&G";

            Bebida cerveja = new Bebida();
            cerveja.Id = 10;
            cerveja.Nome = "Skol";
            cerveja.Preco = 3.50;
            cerveja.TeorAlcoolico = 12.5;
            cerveja.Tipo = "bebida alcoolica";

            sacola.Add(sabonete);
            sacola.Add(cerveja);                        

            //varre item por item da sacola    
            foreach (var item in sacola){
                //identifica o tipo do item que nesse exemplo pode ser Higiene Pessoal ou Bebida (variavel classe recebe o tipo)
                string classe = item.GetType().ToString();

                //Switch para tratar conforme o tipo da variavel item (que está armazenado na variavel classe)
                switch(classe){
                    //caso seja higiene pessoal, acessa a classe filha higiene pessoal para mostrar os atributos do item higiene pessoal
                    case "ExemploLista.HigienePessoal": HigienePessoal higiene = (HigienePessoal) item;
                                                        Console.WriteLine(higiene.Nome+" - "+
                                                                          higiene.Id+" - "+
                                                                          higiene.Marca+" - "+
                                                                          higiene.NumeroMS+" - "+
                                                                          higiene.Preco);
                                                        break;
                    //caso seja bebida, acessa a classe filha para mostrar os atributos do item bebida
                    case "ExemploLista.Bebida":    Bebida bebida = (Bebida) item;
                                                    Console.WriteLine(bebida.Id+" - "+
                                                                      bebida.Nome+" - "+
                                                                      bebida.Preco+" - "+
                                                                      bebida.TeorAlcoolico+" - "+
                                                                      bebida.Tipo);
                                                    break;
                }

            }

        }
    }
}
