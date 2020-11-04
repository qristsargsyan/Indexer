using System;

namespace Indexer
{
    class MyClass1
    {
        private string[] arr = new string[3];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                return "There is no...";
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new Exception("There is no so element...");
                }
            }
        }
    }
}
