

using System.Data;

namespace Casting___OperatorOverloading___Indexer
{
    internal class DataList
    {
        public string[] datas = new string[10];

        public string this[int index]
        {
            get
            {
                return datas[index];
            }
            set
            {
                datas[index] = value;   
            }
        
        }
    }

}

