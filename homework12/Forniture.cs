using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12
{
    public interface IChair
    {
        void HasLegs();
        void SitOn();
    }

    public interface ISofa
    {
        void LieOn();
    }

    public interface ICoffeeTable
    {
        void PlaceItems();
    }

    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
    public class VictorianChair : IChair
    {
        public void HasLegs() => Console.WriteLine("Victorian chair has wooden legs.");
        public void SitOn() => Console.WriteLine("Sitting on a Victorian chair.");
    }

    public class VictorianSofa : ISofa
    {
        public void LieOn() => Console.WriteLine("Lying on a Victorian sofa.");
    }

    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void PlaceItems() => Console.WriteLine("Placing tea on a Victorian coffee table.");
    }

    public class ModernChair : IChair
    {
        public void HasLegs() => Console.WriteLine("Modern chair has metal legs.");
        public void SitOn() => Console.WriteLine("Sitting on a Modern chair.");
    }

    public class ModernSofa : ISofa
    {
        public void LieOn() => Console.WriteLine("Lying on a Modern sofa.");
    }

    public class ModernCoffeeTable : ICoffeeTable
    {
        public void PlaceItems() => Console.WriteLine("Placing coffee on a Modern table.");
    }
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
        public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new ModernSofa();
        public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
    }


}
