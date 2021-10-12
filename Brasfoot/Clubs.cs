using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Brasfoot
{
    public class Clubs
    {
        //Definição de atributos
        private string ownerName;
        private string clubName;
        private int clubMoney;
        private string clubStadium;
        private int clubFans;
        private string clubContry;
        private double clubRating;

        //Encapsulamento dos atributos
        public void setOwnerName()
        {
            Console.WriteLine($"Olá, bem vindo ao Brasfoot Simplificado!{Environment.NewLine}" +
                $"Por favor, digite o seu nome: ");
            ownerName = Console.ReadLine();
            Console.Clear();
        }
        public string getOwnerName()
        {
            return this.ownerName;
        }

        public string getClubName()
        {
            return this.clubName;
        }

        public void setClubName()
        {
            Console.WriteLine("Digite o nome do seu time: ");
            string name = Console.ReadLine();
            this.clubName = name;
            Console.Clear();
        }

        public int getMoney()
        {
            return this.clubMoney;
        }

        public void setMoney()
        {
            Random r = new Random();
            this.clubMoney = r.Next(100000, 50000000);
        }

        public string getStadium()
        {
            return this.clubStadium;
        }

        public void setStadium()
        {
            string name = $"Estádio de várzea do {this.clubName}";
            
        }

        public int getFans()
        {
            return this.clubFans;
        }

        public void setFans()
        {
            Random r = new Random();
            this.clubFans = r.Next(1000000, 40000000);
        }

        public double getRating()
        {
            return this.clubRating;
        }

        public void setRating()
        {
            Random r = new Random();
            double rNumber = r.Next() * (10 - 1) + 1;
            this.clubRating = rNumber;
        }

        public string getCountry()
        {
            return this.clubContry;
        }

        public void setCountry()
        {

        }

        public Clubs()
        {
            setOwnerName();
            setClubName();
            setMoney();
            setStadium();
            setFans();
            setRating();
            setCountry();
        }


        public void showStatus()
        {
            string status = $"Olá, {this.ownerName}{Environment.NewLine}" +
                $"O seu clube: {this.clubName}, atualmente tem {this.clubFans} torcedores e R${this.clubMoney.ToString("F", CultureInfo.InvariantCulture)} em caixa";

            Console.WriteLine(status);
        }







    }
}
