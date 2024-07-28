using System.Collections;
using System.Diagnostics;

namespace CSharpBasic07
{
    internal class Program
    {
        static void Main()
        {
            #region part One 

            //               Structure                             Time Complexity                  Business 
            //                                                 access           insert
            //1.Non Generic Collection

            //  Arraylist :  Array                              O(1)              O(n)              if you want to add Heterogeneous  Data type
            //  HashTable :  Array                              O(1)              O(1)              Fast insertion and Search 
            //2.Generic Collection 

            // List       :  Array                              O(1)              O(n)              if you want to add Homogeneous data type and you want to Retrieve in it         
            // LinkedList :  List Of Node                       O(n)              O(1)              Each node have to part Date and Pointer : if you want to add Homogeneous data type and you want to add item in any place in it
            // Stack      :  Array                              O(1)              O(1)              Last in First out Or First in last out           
            // Queue      :  Array                              O(1)              O(1)              First in First out
            // hashTable  :  Array                              O(1)              O(1)              key + value 

            #region Array list 
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);   
            //arrayList.Add(27);
            //arrayList.Add(2);

            //foreach(var x in  arrayList)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region List
            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //foreach(int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Linked List 
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddLast(1);
            //list.AddFirst(2);
            //list.AddAfter(list.Find(1), 5);
            //list.AddBefore(list.Find(2), 7);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Stack
            // if you add a book 
            //Stack<string> books = new Stack<string>();
            //books.Push("a song of fire and ice");
            //books.Push("Harry Potter");
            //books.Push("The Lord of the ring");

            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Queue

            // to make queue in super market the first one in the first one out
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Ahmed");
            //queue.Enqueue("Abdo");
            //queue.Enqueue("Mohamed");
            //queue.Enqueue("Omar");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region HashTable Non Generic
            //Hashtable PhoneEmp = new Hashtable();
            //PhoneEmp.Add("Abdo", 132);
            //PhoneEmp.Add("Ahmed", 432);
            //PhoneEmp.Add("Ali", 132);
            //PhoneEmp.Add("Mohab", 455);

            //foreach(KeyValuePair<string,int> x in PhoneEmp)
            //{
            //    Console.WriteLine(x.Value);
            //    Console.WriteLine(x.Key);
            //}
            #endregion

            #region HashTable(Dictionary) Generic 

            //Dictionary<string ,int> phoneBook = new Dictionary<string ,int>();
            //phoneBook.Add("Abdo", 132);
            //if (!phoneBook.ContainsKey("Ahmed"))
            //    phoneBook.Add("Ahmed", 432);
            //else
            //    phoneBook["Ahemd"] = 7447;
            //phoneBook.Add("Ali", 132);
            //phoneBook.Add("Mohab", 455);

            //foreach (KeyValuePair<string,int> x in PhoneEmp)
            //{
            //    Console.WriteLine(x.Key);
            //    Console.WriteLine(x.Value);
            //}
            #endregion



            #endregion

            #region Part Two
            #region One

            //ArrayList arrayOfList = new ArrayList() { 1 , 4 , 5 , 68 , 74, 8 , 14};
            ////arrayOfList.Reverse();
            //for (var i = 0; i < arrayOfList.Count/2; i++)
            //{
            //    var temp = arrayOfList[i];
            //    arrayOfList[i] = arrayOfList[arrayOfList.Count-i-1];
            //    arrayOfList[arrayOfList.Count-i-1] = temp;
            //}
            //foreach(var item in arrayOfList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Two
            //List<int> list = new List<int>() { 1, 4, 5, 68, 74, 8, 14 };
            //List<int> Evenlist = new List<int>();
            //foreach (var element in list)
            //{
            //    if (element %2 ==  0)
            //    { Evenlist.Add(element); }
            //}
            //foreach (var z in Evenlist)
            //{
            //    Console.WriteLine(z);
            //}
            #endregion

            #region Three

            #endregion

            #region Four
            string x = Console.ReadLine();
            Dictionary<char , int> dict = new Dictionary<char , int>();
            for (int i = 0;i < x.Length; i++)
            {
                if (dict.ContainsKey(x[i]))
                    dict[x[i]]++;
                else
                    dict[x[i]] = 0;
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (dict[x[i]] == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            #endregion
            #endregion

        }
    }
}
