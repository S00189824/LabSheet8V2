using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class ComputerGame
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }

        
        public virtual List<Character> Characters { get; set; }

        public override string ToString()
        {
            return GameName;
        }
    }

    public class Character
    {
        public int CharacterID { get; set; }
        public int ID { get; set; }
        public string CharacterName { get; set; }
        public string CharacterImage  { get; set; }

        public virtual ComputerGame ComputerGame { get; set; }

        public override string ToString()
        {
            return CharacterName;
        }
    }

    public class ComputerGameData : DbContext
    {
        public ComputerGameData() : base("MyComputerGames") { }

        public DbSet<ComputerGame> Games { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}
