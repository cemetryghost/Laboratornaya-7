namespace ConsoleApp6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Audi audi = new Audi();
            Console.WriteLine(audi.PropInfo());

            SuperJet superjet = new SuperJet();
            Console.WriteLine(superjet.PropInfo());

            Aurora aurora = new Aurora();
            Console.WriteLine(aurora.PropInfo());
        }
    }

    public abstract class Transport
    {
        public abstract double Speed { get; }
        public abstract double CarryingCapacity { get; }
        public abstract double Range { get; }

        public abstract string PropInfo();
    }

    public abstract class Car : Transport
    {
        public string Brand { get; set; }

        public override string PropInfo()
        {
            return $"{Brand} грузоподъемностью в {CarryingCapacity} кг может проехать {Range} км!";
        }
    }

    public abstract class Airplane : Transport
    {
        public string Model { get; set; }

        public override string PropInfo()
        {
            return $"{Model} грузоподъемностью в {CarryingCapacity} кг может пролететь {Range} км!";
        }
    }

    public abstract class Ship : Transport
    {
        public string Name { get; set; }

        public override string PropInfo()
        {
            return $"{Name} грузоподъемностью в {CarryingCapacity} кг может плавать на расстояние {Range} км!";
        }
    }

    public class Audi : Car
    {
        public override double Speed 
        {
            get { return 300; }
        } 
        public override double CarryingCapacity
        {
            get { return 1000; }
        }
        public override double Range
        {
            get { return 2000; }
        } 
        public Audi()
        {
            Brand = "Audi RS6";
        }
    }

    public class SuperJet : Airplane
    {
        public override double Speed {
            get { return 1600; }
        }
        public override double CarryingCapacity
        {
            get{ return 50000; }
        }

        public override double Range {
            get { return 15000; }
        }

        public SuperJet()
        {
            Model = "SuperJet №769001";
        }
    }

    public class Aurora : Ship
    {
        public override double Speed
        {
            get { return 70; }
        }

        public override double CarryingCapacity
        {
            get { return 8000; }
        }

        public override double Range
        {
            get { return 3000; }
        }

        public Aurora()
        {
            Name = "Aurora";
        }
    }
}