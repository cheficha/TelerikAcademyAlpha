using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length,decimal width) : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.area = this.Length * this.Width;
        }

        public decimal Length { get { return this.length; }set {this.length=value; } }

        public decimal Width { get { return this.width; } set { this.width = value; } }

        public decimal Area { get { return this.area; } set { this.area = value; } }
        protected override string AdditionalInfo()
        {
            return $"Length:{this.Length},Width:{this.Width},Area:{this.Area}";
        }
    }
}
