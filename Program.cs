using personnage;

class Program
{
    public static void Main(string[] args)
    {
        // Deux personnages
        Character PersoneOne = new Character("Paul", 500, 200, 100);
        Character PersoneTwo = new Character("Clara", 300, 100, 50);

        while (PersoneOne.IsAlive() && PersoneTwo.IsAlive())
        {
            PersoneOne.attack(PersoneTwo);

            if (PersoneTwo.IsAlive() == false)
            {
                Console.WriteLine($"{PersoneOne.Name} a gagné le combat !");
                break;
            }

            PersoneTwo.attack(PersoneOne);

            if (PersoneTwo.IsAlive() == false)
            {
                Console.WriteLine($"{PersoneTwo.Name} a gagné le combat !");
                break;
            }
        }
    }
}

