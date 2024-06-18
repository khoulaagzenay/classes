using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace personnage
{
    public class Character
    {
        //attributs / propriétés
        public string Name { get; set; }
        public int PointVie { get; set; }
        public int ForceAttaque { get; set; }
        public int ForceDefense { get; set; }


        // Constructeur
        public Character(string name, int LifePoint, int attackPower, int defensePower)
        {
            Name = name;
            PointVie = LifePoint;
            ForceAttaque = attackPower;
            ForceDefense = defensePower;
        }

        //Une méthode IsAlive()
        public bool IsAlive()
        {
            return PointVie > 0;
        }

        //méthode Attack()
        public void attack(Character OtherOne)
        {
            int points = ForceAttaque - OtherOne.ForceDefense;
            if (points > 0)
            {
                OtherOne.PointVie -= points;
                Console.WriteLine($"{Name} attaque {OtherOne.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} attaque {OtherOne.Name} mais n'inflige aucun dégât.");
            }

            if (OtherOne.PointVie <= 0)
            {
                Console.WriteLine($"{OtherOne.Name} est mort.");
            }
        }
    }
}
