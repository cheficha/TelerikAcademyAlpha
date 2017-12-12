using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;

namespace Training
{
    class GenericList<T> where T : IComparable
    {
       
        private T[] elements;
        private int count = 0;
        private int capacity;
       
      
        public GenericList(int capacityOfarray)
        {
            this.capacity = capacityOfarray;
            this.Elements = new T[this.capacity];
        }
        public int Count { get {return this.count; } }
        public int Capacity { get {return this.capacity; } set {this.capacity=value; } }

        public T[] Elements { get => elements; set => elements = value; }

        public void AddElement(T element)
        {
            Guard.WhenArgument(count, "Count is wrong").IsGreaterThanOrEqual(this.Elements.Length).Throw();
            this.Elements[count] = element;
            count++;

            ResizeCapacity();

        }
        public T AccessElement(int index)
        {
            Guard.WhenArgument(index, " ").IsGreaterThan(this.Elements.Length).IsLessThan(0).Throw();
            return this.Elements[index];
        }
        public void RemoveElement(int index)
        {
            count--;
            T[] newArr = new T[this.Elements.Length-1];
            for (int i = 0; i <newArr.Length; i++)
            {
                if (index==0)
                {
                    if (i + 1 > this.Elements.Length)
                    {
                        break;
                    }
                    else
                    {
                        newArr[i] = this.Elements[i + 1];
                    }
                    
                }
                else if (index == Elements.Length-1)
                {
                    if (index != i)
                    {
                        newArr[i] = this.Elements[i];
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (index != i)
                    {
                        newArr[i] = this.Elements[i];
                    }
                    else
                    {
                        newArr[i] = this.Elements[i + 1];
                    }
                }
              
            }
            this.Elements = new T[newArr.Length];
            for (int j = 0; j < newArr.Length; j++)
            {
                this.Elements[j] = newArr[j];
            }
        }
        public void InsertElement(int index,T value)
        {
            count++;
            ResizeCapacity();
           

            if (count > this.Capacity)
            {
                Capacity = this.capacity * 2;
            }
            for (int i = count; i > index ; i--)
            {
                this.Elements[i] = this.Elements[i - 1];
            }
           this.Elements[index] = value;
        }
        public T Max()
        {
            T max = this.Elements[0];
            for (int i = 1; i < count; i++)
            {
                if (max.CompareTo(this.Elements[i]) < 0)
                {
                    max = this.Elements[i];
                }
            }
            return max;
        }
        public T Min()
        {
            T min = this.Elements[0];
            for (int i = 1; i < count; i++)
            {
                if (min.CompareTo(this.Elements[i]) > 0)
                {
                    min = this.Elements[i];
                }
            }
            return min;
        }
        private void ResizeCapacity()
        {
            if (this.Count>(this.Capacity*3)/4)
            {
                this.Capacity *= 2;
                T[] newArrA = (T[])elements.Clone();
                Array.Resize(ref newArrA,this.Capacity);
                this.elements = (T[])newArrA.Clone();

            }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Elements[i]);
            }
        }


    }
}
