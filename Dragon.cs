
public class Dragon : Enemy{
    public Dragon(string name, int health) : base(name, health)
    {
         base.Name = "Dragon";
        base.Health = 1000;
        
    }

    public override void attack(){
        Console.WriteLine("Dragon attacks!");
        
    }

}