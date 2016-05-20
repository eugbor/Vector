namespace Vector
{
    using System.Collections;
    using System.Collections.Generic;

    public class Vectors : IEnumerable<Vector<int>> 
    {
        private List<Vector<int>> list = new List<Vector<int>>();

        public Vectors()
        {
            list.Add(new Vector<int>(3, 4));
            list.Add(new Vector<int>(2, 6));
            list.Add(new Vector<int>(1, 6));
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<Vector<int>>)list).GetEnumerator();
        }

        IEnumerator<Vector<int>> IEnumerable<Vector<int>>.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
