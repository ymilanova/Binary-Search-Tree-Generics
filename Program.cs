namespace Binary_Search_Tree_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BST<int> BT = new BST<int>();
            BT.Insert(50);
            BT.Insert(30);
            BT.Insert(70);
            BT.Insert(40);
            BT.Insert(45);
            BT.Insert(46);
            BT.Insert(47);
            BT.Insert(48);
            BT.Insert(20);
            BT.Insert(50);
            BT.Insert(55);
            BT.Insert(60);
            BT.Insert(68);
            BT.Insert(67);
            BT.Insert(69);
            BT.Insert(80);
            BT.Contains(40);
            BT.Search(4);
            BT.Search(15);

            
            //BT.Delete(69);
           
            Console.ReadLine();

        }
    }
}
