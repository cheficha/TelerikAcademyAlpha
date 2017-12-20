using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        
        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {

        }

        public bool IsConverted { get { return this.isConverted; } set { this.isConverted = value; } }
       
       

        public void Convert()
        {
            IsConverted = true;
            this.Height = 0.10m;
        }
    }
}
