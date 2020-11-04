namespace Indexer
{
    class Dictionary
    {
        private string[] key = new string[3];
        private string[] value = new string[3];

        public Dictionary()
        {
            key[0] = "Girq"; value[0] = "Book";
            key[1] = "Jur"; value[1] = "Water";
            key[2] = "Katu"; value[2] = "Cat";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + "---" + value[i];
                }
                return $"There is no translation...";
            }
        }
    }
}
