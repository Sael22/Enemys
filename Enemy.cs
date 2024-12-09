using System.Reflection.Metadata.Ecma335;

public class Enemy{
    public String Name = "Enemy";
    public int Health = 0;
    public static int Damage;
    public Enemy(String name, int health ){
        Name = name;
        Health = health;
        
    }
   
    public virtual void attack(){
        Console.WriteLine($"Enemy attacks!");

    }
    
    public void TakeDamage(int damage) {
        Health -= damage;
        Console.WriteLine("The remaining Health is " + Health);
    }
}