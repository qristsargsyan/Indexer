namespace Indexer
{
    class BaseClass
    {
        private string[] baseArray = null;

        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "1";
            baseArray[1] = "2";
            baseArray[2] = "3";
        }

        public virtual string this[int index]
        {
            get
            {
                return baseArray[index];
            }
                 
        } 
    }
}
