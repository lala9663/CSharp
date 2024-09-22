namespace CSharp;

public class IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 0;
            bool isDead = (hp <= 0);

            if (isDead)
            {
                Console.WriteLine("You are Dead!");
                Console.WriteLine("You are Dead!");
            }

            if (isDead == false)
            {
                Console.WriteLine("You are Alive!");
            }
        }
    }
};