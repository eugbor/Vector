namespace Vector
{
    using System;

    public class Vector<T> where T : struct, IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }

        public double length { get; set; }

        public Vector(T x, T y)
        {
            X = x;
            Y = y;
            length = Math.Sqrt(Math.Pow((dynamic)x, 2) + Math.Pow((dynamic)y, 2));
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lenght: {2:F2}", this.X, this.Y, this.length);
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(Vector<T> other)
        {
            if (this.length > other.length)
                return 1;
            if (this.length < other.length)
                return -1;
            else
                return 0;
        }

        public static Vector<T> operator +(Vector<T> p1, Vector<T> p2)
        {
            return new Vector<T>((dynamic)p1.X + (dynamic)p2.X, (dynamic)p1.Y + (dynamic)p2.Y);
        }

        public static Vector<T> operator -(Vector<T> p1, Vector<T> p2)
        {
            return new Vector<T>((dynamic)p1.X - (dynamic)p2.X, (dynamic)p1.Y - (dynamic)p2.Y);
        }

        public static bool operator >(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) > 0);
        }

        public static bool operator <(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) < 0);
        }

        public static bool operator ==(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) == 0);
        }

        public static bool operator !=(Vector<T> p1, Vector<T> p2)
        {
            return ((dynamic)p1.CompareTo((dynamic)p2) != 0);
        }
    }
}
