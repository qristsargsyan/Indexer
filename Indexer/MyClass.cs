namespace Indexer
{
    class MyClass
    {
        private int[] array = new int[3];

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }
}
