public class Goblin : Enemy{
    public Goblin(string name, int health) : base(name, health)
    {
         base.Name = "Goblin";
        base.Health = 50;
        
    }

    public override void attack(){
        Console.WriteLine("Goblin attacks!");
        Health--;
    }
}