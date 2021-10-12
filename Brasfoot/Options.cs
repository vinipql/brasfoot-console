using System;
using System.Collections.Generic;
using System.Text;

namespace Brasfoot
{
    public class Options
    {
        

        public static bool MainMenu()
        {
            Clubs c1 = new Clubs();
           

            List<int> optionNumber = new List<int> { 1, 2, 3, 4 };

            
                Console.Clear();
                Console.WriteLine($"Esse é o menu do Brasfoot, {c1.getOwnerName()}{Environment.NewLine}" +
                    $"Escolha uma das opções abaixo para prosseguir{Environment.NewLine}" +
                    $"1 - Ver o elenco atual{Environment.NewLine}" +
                    $"2 - Verificar a tabela do campeonato nacional{Environment.NewLine}" +
                    $"3 - Verificar calendario dos próximos jogos{Environment.NewLine}" +
                    $"4 - Acessar o mercado de transferencias{Environment.NewLine}" +
                    $"5 - Ver status atual do clube{Environment.NewLine}" +
                    $"6 - Sair do Jogo");



                switch (Console.ReadLine())
                {
                    case "1":
                        
                        return true;
                    case "2":
                        return true;
                    case "3":
                         return true;
                    case "4":
                        return true;
                    case "5":
                        c1.showStatus();
                        return true;
                    case "6":
                        return false;
                    default:
                        return true;
                }
              

        }
    }
}
