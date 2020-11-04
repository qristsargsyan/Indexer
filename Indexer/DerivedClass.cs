namespace Indexer
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;

        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "One";
            derivedArray[1] = "two";
            derivedArray[2] = "Three";
        }

        public override string this[int index]
        {
            get
            {
                return base[index] + "---" + derivedArray[index];
            }
        }
    }
}
