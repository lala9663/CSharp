namespace CSharp;

public class Study
{
    static void main(string[] args)
    {
        // int
        // float
        // string
        // bool
        
        // isAdmin = true/false
        // soundOnOff = true/false
        // autoPlay = true/false

        
        
        // "1"
        // string input = Console.ReadLine();
        //
        // int number = int.Parse(input);
        // Console.WriteLine(number);

        int hp = 100;
        int maxHp = 100;

        string message = "당신의 HP는" + hp + "입니다";
        Console.WriteLine(message);

        string.Format("당신의 HP는 {0} {1} 입니다", hp, maxHp);
        Console.WriteLine(message);
        
        string message1 = $"당신의 HP는 {hp} / {maxHp}입니다";
        Console.WriteLine(message1);
        
    }
}