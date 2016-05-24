namespace Vector
{
    using System;

    // generic class with a limitation on the structure
    //and must implement comparison interface
    public class Vector<T> where T : struct, IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }

        public double length { get; set; }

        public Vector(T x, T y)
        {
            X = x;
            Y = y;
            // Formula vector module
            // Class Math provides methods that
            //returns the square root of the specified number
            //and returns a specified number raised to the specified power           
            // Dynamic calculation type of data
            length = Math.Sqrt(Math.Pow((dynamic)x, 2) + Math.Pow((dynamic)y, 2));
        }

        // implementation method returns a string
        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lenght: {2:F2}", this.X, this.Y, this.length);
        }

        // implementation of the method of comparison
        //object to the current object
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        // implementation of the method requires
        //quick test object equality
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        //method compares the current object with another object
        public int CompareTo(Vector<T> other)
        {
            if (this.length > other.length)
                return 1;
            if (this.length < other.length)
                return -1;
            else
                return 0;
        }

        // static method of a binary operator +
        public static Vector<T> operator +(Vector<T> p1, Vector<T> p2)
        {
            return new Vector<T>((dynamic)p1.X + (dynamic)p2.X, (dynamic)p1.Y + (dynamic)p2.Y);
        }

        // static method of a binary operator -
        public static Vector<T> operator -(Vector<T> p1, Vector<T> p2)
        {
            return new Vector<T>((dynamic)p1.X - (dynamic)p2.X, (dynamic)p1.Y - (dynamic)p2.Y);
        }

        // static method comparison operator "more"
        public static bool operator >(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) > 0);
        }

        // static method comparison operator "less"
        public static bool operator <(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) < 0);
        }

        // static method operator equality
        public static bool operator ==(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) == 0);
        }

        // static method operator inequality
        public static bool operator !=(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) != 0);
        }
    }
}
