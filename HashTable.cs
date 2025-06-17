using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asd_laba_7
{
    internal class HashTable
    {
        private string[] table;
        private int size;
        private const string DELETED = "<deleted>";

        public HashTable(int size)
        {
            this.size = size;
            table = new string[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash += key[i] * (i + 1);
            }
            return hash % size;
        }

        public void Insert(string key)
        {
            int index = Hash(key);
            int startIndex = index;
            while (table[index] != null && table[index] != DELETED)
            {
                if (table[index] == key)
                {
                    Console.WriteLine("Такий ПІБ вже існує.");
                    return;
                }

                index = (index + 1) % size;
                if (index == startIndex)
                {
                    Console.WriteLine("Таблиця переповнена.");
                    return;
                }
            }
            table[index] = key;
        }

        public bool Search(string key)
        {
            int index = Hash(key);
            int startIndex = index;
            while (table[index] != null)
            {
                if (table[index] == key)
                    return true;

                index = (index + 1) % size;
                if (index == startIndex)
                    break;
            }
            return false;
        }

        public bool Delete(string key)
        {
            int index = Hash(key);
            int startIndex = index;
            while (table[index] != null)
            {
                if (table[index] == key)
                {
                    table[index] = DELETED;
                    return true;
                }
                index = (index + 1) % size;
                if (index == startIndex)
                    break;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine("\nХеш-таблиця:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i}: {(table[i] == null ? "<порожньо>" : table[i])}");
            }
        }
    }
}
