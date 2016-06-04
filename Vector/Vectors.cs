namespace Vector
{
    using System.Collections;
    using System.Collections.Generic;

    // generic class must implement enumeration interface
    public class Vectors : IEnumerable<Vector<int>> 
    {
        // list of similar objects
        private List<Vector<int>> list = new List<Vector<int>>();

        public Vectors()
        {
            list.Add(new Vector<int>(3, 4));
            list.Add(new Vector<int>(2, 6));
            list.Add(new Vector<int>(1, 6));
        }

        // implementation enumeration interface
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator<Vector<int>> IEnumerable<Vector<int>>.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
