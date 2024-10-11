namespace ConsoleApp8
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Indiki array:");
            foreach (int i in array) 
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("");
            InsertArray(ref array,7,8,9);
        }
        static void InsertArray(ref int[] array, params int[] deyer) 
        {
            int[] newArray = new int[array.Length+deyer.Length];
            array.CopyTo( newArray, 0 );

            for (int i = 0; i < deyer.Length; i++)
            {
                newArray[array.Length + i] = deyer[i]; 
            }
            Console.WriteLine("Yeni array:");
            foreach (int i in newArray)
            {
                Console.Write(i+" ");
            } 
            newArray=array;
            Console.WriteLine("");
            Console.WriteLine("Arrayi kohne qiymetine qaytaraq:");
            foreach (int i in newArray)
            {
                Console.Write(i+" ");
            }
        }
    }


}
