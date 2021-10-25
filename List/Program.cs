using List.collections;
using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            mylist<string> list = new mylist<string>();
            list.Add("user1");
            list.Add("user2");
            list.Add("user3");
            list.Add("user4");
            list.Add("user5");
            list.Add("user6");
            list.Add("user7");
            list.Add("user8");
            list.Add("user9");
            list.Add("user10");
            list.Add("user11");
            list.Add("user12");
            list.Add("user13");
            list.Add("user14");
            list.Add("user15");
            list.Add("user16");
            mylist<int> list2 = new mylist<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            Console.WriteLine(list.Contains("user2"));
            //Console.WriteLine(list2.Find(i=>i%100==0));
        }
    }
}
