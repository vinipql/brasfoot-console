using System;

namespace Brasfoot
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Options.MainMenu();
            }
        }
    }
}
