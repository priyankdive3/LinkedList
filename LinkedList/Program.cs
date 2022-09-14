namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option.\n1.Simple Linked List.\n2.Byadd\n4.Ability to insert in between.\n5.delete the first element in the LinkedList.\n6.delete the last element in the LinkedList.\n7.Search Node 30.\n8.Insert 40 after 30");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(option)
            {
                 case 1:
                    SimpleLinkedList simpleLinkedList = new SimpleLinkedList();
                    simpleLinkedList.Simple(56);
                    simpleLinkedList.Simple(30);
                    simpleLinkedList.Simple(70);
                    simpleLinkedList.Display();
                 break;
                case 2:
                    ByAdding byadd = new ByAdding();
                    byadd.Add(56);
                    byadd.InsertElement1(30,2);
                    byadd.InsertElement2(70,3);
                    byadd.Display();
                    break;
                case 4:
                    InsertInBetween between = new InsertInBetween();
                    between.Add(56);
                    between.Add(70);
                    between.InsertBetween(30, 2);
                    between.Display();
                break;
                default:
                case 5:
                    DeleteFirstElement deletef = new DeleteFirstElement();
                    deletef.Add(56);
                    deletef.Add(30);
                    deletef.Add(70);
                    Console.WriteLine("{0} is a deleted in the linked list ", deletef.DeleteFirstNode());
                    Console.WriteLine("Element in linked list are ");
                    deletef.Display();
                break;
                case 6:
                    DeleteLastElement deletel = new DeleteLastElement();
                    deletel.Add(56);
                    deletel.Add(30);
                    deletel.Add(70);
                    Console.WriteLine("{0} is a deleted in the linked list ", deletel.DeleteLastNode());
                    Console.WriteLine("Element in linked list are ");
                    deletel.Display();
                    break;
                case 7:
                    SearchNode search = new SearchNode();
                    search.Add(56);
                    search.Add(30);
                    search.Add(70);
                    search.Searchnode(30);
                    break;
                case 8:
                    InsertNewElement insertnewelement = new InsertNewElement();
                    insertnewelement.Add(56);
                    insertnewelement.Add(30);
                    insertnewelement.Add(70);
                    insertnewelement.InsertElement(40, 3);
                    insertnewelement.Display();
                    break;

                    Console.WriteLine("Invalid Option");
                    break;
           }
       }
    }
}