public class Zombie : Enemy
{
    public Zombie(string name, int health) : base(name, health)
    {
        base.Name = "Zombie";
        base.Health = 100;
        


    }
    

    public override void attack(){
        Console.WriteLine("Zombie attacks!");
if(Damage < 10){
              Health = this.Health;
        }

    }
}
