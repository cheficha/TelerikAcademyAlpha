using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;

        }

        public int NumberOfLegs { get { return this.numberOfLegs; } set { this.numberOfLegs = value; } }
        protected override string AdditionalInfo()
        {
            return $"Number Of Legs:{this.NumberOfLegs}";
        }
    }
}
