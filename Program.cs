public class Program{
    
    public static void Main()
    {
        Goblin goblin = new Goblin("Goblin",50);
        Dragon dragon = new Dragon("Dragon",1000);
        Zombie zombie = new Zombie("Zombie",100);
        Enemy [] enemies = new Enemy[3];
      
       enemies[0] = goblin;
       enemies[1] = dragon;
       enemies[2] = zombie;
       
       Console.WriteLine($"{goblin.Name} has {goblin.Health} health");
       Console.WriteLine($"{dragon.Name} has {dragon.Health} health");
       Console.WriteLine($"{zombie.Name} has {zombie.Health} health");


      

       foreach(var enemy in enemies)
       {
        Console.WriteLine($"{enemy.Name} Enter Damge");
       int d = int.Parse(Console.ReadLine());
         
            
        

            while(enemy.Health > 0)
            {
                
                enemy.TakeDamage(d);

                
            
                
                
                if(enemy.Health <= 0)
                {
                    Console.WriteLine($"You defeated {enemy.Name}!");
                    break;
                }


    


                
            }
       }
    }

    
    

       

       


       
        
        
        
       

        

        
}
