using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemsV_IV
{
    public class GenericList<T> where T: IComparable<T>
    {
        private const int INITAL_LIST_SIZE=4;
        private T[] genericList;
        private int count;
        private int capacity;
        private int nextIndex;

        public GenericList()
        {
            genericList = new T[INITAL_LIST_SIZE];
            this.Count=0;
            this.Capacity = 0;
        }


        public T this[int index]

        {
            get
            {
              
                return this.genericList[index];
            }
            set
            {
                if (0 < index || index > this.nextIndex)
                {
                    throw new IndexOutOfRangeException();
                } 
                this.genericList[index] = value;
            }

        }

        public T Max()
        {
            T maxValue = genericList[0];
            for (int i = 0; i < Count; i++)
            {
                if (maxValue.CompareTo(genericList[i])<0)
                {
                    maxValue = genericList[i];
                }
            }
            return maxValue;
        }
        public T Min()
        {
            T maxValue = genericList[0];
            for (int i = 0; i < Count; i++)
            {
                if (maxValue.CompareTo(genericList[i]) > 0)
                {
                    maxValue = genericList[i];
                }
            }
            return maxValue;
        }

        public void Add(T element)
        {
            if (nextIndex+ 1 == this.genericList.Length)
            {
                DoubleSize();
            }

            this.genericList[nextIndex] = element;
            this.nextIndex++;
            this.Count++;
            this.Capacity = genericList.Length;
        }

        private void DoubleSize()
        {
            T[] newList = new T[this.genericList.Length * 2];
            for(int i = 0; i<this.genericList.Length;i++)
            {
                newList[i]=this.genericList[i];
            }
            this.genericList=newList;
        }

        public void InsertAt(int index, T element)
        {
            if (nextIndex + 1 == this.genericList.Length)
            {
                DoubleSize();
            }

            for (int i = this.nextIndex + 1; i > index; i--)
            {
                this.genericList[i] = this.genericList[i - 1];
            }
            this.genericList[index] = element;
            nextIndex++;
            this.Count++;
        }
        public void RemoveAt(int index)
        {
            if (0 > index || index >= this.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < Capacity-1; i++)
            {
                genericList[i] = genericList[i + 1];
            }
            this.nextIndex--;
            this.Count--;
        }
        public int IndexOf(T element)
        {
            int Index = -1;

            for (int i = 0; i < Count - 1; i++)
            {
                if (genericList[i].Equals(element))
                {
                    Index = i;
                    break;
                }
            }
            return Index;
        }
        public void Clear()
        {
            this.genericList = new T[INITAL_LIST_SIZE];
            this.Capacity = 0;
            this.Count = 0;
        }
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.nextIndex; i++)
            {
                Console.WriteLine("[{0}]= {1}", i, genericList[i]);
            }

            return result.ToString().Trim();
        }

    }
}
