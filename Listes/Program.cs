namespace Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> list1 = new List<string>();
            list1.Add("Hello");
            list1.Add("world");
            list1.Add("Hy");

            list1.RemoveAt(0);  
            list1.Remove("world");
            list1[0] = "Hello world";

            foreach (string str in list1)
            {
                Console.WriteLine(str);
            }
        }
    }
}
