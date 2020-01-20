using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Patrick = new Human("Patrick");
            Patrick.Eat();
            Patrick.Move();
            Console.WriteLine();

            Monkey Chitah = new Monkey("Chitah");
            Chitah.Eat();
            Chitah.Move();
            Console.WriteLine();

            Lezards Georges = new Lezards("Georges", 4);
            Georges.Eat();
            Georges.Move();
            Console.WriteLine();

            Reptilians Chameleon = new Reptilians("Pascal", 4, 4, false);
            Chameleon.Eat();
            Chameleon.Move();
            Console.WriteLine();

            Tortoise Caroline = new Tortoise("Caroline", 4);
            Caroline.Eat();
            Caroline.Move();
            Console.WriteLine();

            Snake WistlerFather = new Snake("Père siffleur");
            WistlerFather.Eat();
            WistlerFather.Move();
        }
    }

    public abstract class Animal
    {
        private string _Name;
        protected bool _IsHairy;
        protected int _LegsNumber;
        protected int _EyesNumber;
        protected int _HandFingers;
        protected bool _IsNose;
        protected bool _IsColdBlood;
        protected bool _HasShell;
        
        public Animal(string Name, bool IsHairy, int LegsNumber, int EyesNumber, int HandFingers, bool IsNose, bool IsColdBlood, bool HasShell)
        {
            _Name = Name;
            _IsHairy = IsHairy;
            _LegsNumber = LegsNumber;
            _EyesNumber = EyesNumber;
            _HandFingers = HandFingers;
            _IsNose = IsNose;
            _IsColdBlood = IsColdBlood;
            _HasShell = HasShell;
        }

        public virtual void Eat()
        {
            Console.WriteLine("I eat with my mouth and i chew.");
        }

        public virtual void Move()
        {
            Console.WriteLine("I walk");
        }
    }

    public class Mammal : Animal
    {
        protected bool _OpposableTumb;
        public Mammal(string name, bool OpposableTumb) : base(name, true, 4, 2, 5, true, false, false)
        {
            _OpposableTumb = OpposableTumb;
        }
    }

    public class Human : Mammal
    {
        public Human(string name) : base (name, true)
        {

        }
    }

    public class Monkey : Mammal
    {
        public Monkey(string name) : base(name, false)
        {

        }

        public override void Move()
        {
            Console.WriteLine("I climb in the trees");
        }
    }

    public class Reptilians : Animal
    {
        public Reptilians(string name, int LegsNumber, int HandFingers, bool HasShell) : base (name, false, LegsNumber, 2, HandFingers, false, true, HasShell)
        {

        }

        public override void Move()
        {
            Console.WriteLine("I often walk but i can also crawl depending who i am...");
        }
    }

    public class Lezards : Reptilians
    {
        public Lezards(string name, int HandFingers) : base (name, 4, HandFingers, false)
        {

        }
        public override void Move()
        {
            Console.WriteLine("I run");
        }
    }

    public class Tortoise : Reptilians
    {
        public Tortoise(string name, int HandFingers) : base(name, 4, HandFingers, true)
        {

        }
        public override void Move()
        {
            Console.WriteLine("I walk slowly and i can eventually swim");
        }
    }

    public class Snake : Reptilians
    {
        public Snake(string Name) : base(Name, 0, 0, false)
        {

        }
        public override void Move()
        {
            Console.WriteLine("I crawl in the grass, in the trees and in your nightmares!");
        }

        public override void Eat()
        {
            Console.WriteLine("I swallow my preys and digest them slowly!");
        }
    }
}
