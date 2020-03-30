using Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerGameData db = new ComputerGameData();

            using (db)
            {
                ComputerGame g1 = new ComputerGame { GameID = 1, GameName = "Borderlands", YearReleased = 2019, Genre = "FPS" };
                Character p1 = new Character { CharacterID = 1, CharacterName = "Flak", CharacterImage = "c1", ComputerGame = g1,GameID = 1 };
                Character p2 = new Character { CharacterID = 2, CharacterName = "Amara", CharacterImage = "c4", ComputerGame = g1,GameID = 1 };

                ComputerGame g2 = new ComputerGame { GameID = 2, GameName = "Gran Blue Fantasy", YearReleased = 2020, Genre = "RPG" };
                Character p3 = new Character { CharacterID = 3, CharacterName = "Emilia", CharacterImage = "c3",ComputerGame = g2,GameID = 2 };
                Character p4 = new Character { CharacterID = 4, CharacterName = "Tom", CharacterImage = "c2",ComputerGame = g2,GameID = 2 };

                db.Games.Add(g1);
                db.Games.Add(g2);

                Console.WriteLine("Added Game to Database");

                db.Characters.Add(p1);
                db.Characters.Add(p2);
                db.Characters.Add(p3);
                db.Characters.Add(p4);

                Console.WriteLine("Added Characters to database");

                db.SaveChanges();

                Console.WriteLine("Saved Changed to database");
            }
        }
    }
}
