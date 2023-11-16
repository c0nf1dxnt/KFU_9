using System;
using System.Text;

namespace Part2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Skynet";
            Console.WriteLine("Task: Создать команды и игры для шоу \"Большие Гонки\", создать метод добавления новых игр");
            Console.WriteLine("Шоу \"Большие Гонки\"");

            Team RussiaTeam = new Team("Russia");
            Team FranceTeam = new Team("France");
            Team ChinaTeam = new Team("China");
            Team KazakhstanTeam = new Team("Kazakhstan");

            RussiaTeam.AddGame(new Beach());
            RussiaTeam.AddGame(new Mousetrap());
            RussiaTeam.AddGame(new Sea());
            RussiaTeam.AddGame(new Fishing());
            RussiaTeam.AddGame(new Postmen());
            RussiaTeam.AddGame(new Slide());

            FranceTeam.AddGame(new Beach());
            FranceTeam.AddGame(new Mousetrap());
            FranceTeam.AddGame(new Sea());
            FranceTeam.AddGame(new Fishing());
            FranceTeam.AddGame(new Postmen());
            FranceTeam.AddGame(new Slide());

            ChinaTeam.AddGame(new Beach());
            ChinaTeam.AddGame(new Mousetrap());
            ChinaTeam.AddGame(new Sea());
            ChinaTeam.AddGame(new Fishing());
            ChinaTeam.AddGame(new Postmen());
            ChinaTeam.AddGame(new Slide());

            KazakhstanTeam.AddGame(new Beach());
            KazakhstanTeam.AddGame(new Mousetrap());
            KazakhstanTeam.AddGame(new Sea());
            KazakhstanTeam.AddGame(new Fishing());
            KazakhstanTeam.AddGame(new Postmen());
            KazakhstanTeam.AddGame(new Slide());

            RussiaTeam.PlayGames();
            FranceTeam.PlayGames();
            ChinaTeam.PlayGames();
            KazakhstanTeam.PlayGames();

            Soccer soccer = new Soccer();
            RussiaTeam.AddGame(soccer);
            FranceTeam.AddGame(soccer);
            ChinaTeam.AddGame(soccer);
            KazakhstanTeam.AddGame(soccer);

            Console.ReadKey();
        }
    }
}
