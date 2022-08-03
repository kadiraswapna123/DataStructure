using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndAlgorithms
{
    internal class UC_6_HashingFunction
    {
        void search(string s)
        {
            int index = hashFunc(s);
            for (int i = 0; i < hashTable[index].size(); i++)
            {
                if (hashTable[index][i] == s)
                {
                    cout << s << " is found!" << endl;
                    return;
                }
            }
            cout << s << " is not found!" << endl;
        }
    }
}
