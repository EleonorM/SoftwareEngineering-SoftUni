﻿namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {this.Value}";
        }
    }

}
