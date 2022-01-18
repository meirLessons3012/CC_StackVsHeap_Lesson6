using System;

namespace CC_StackVsHeap_Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack/Heap
            int x1 = 10;
            int y = x1;

            //Heap 
            string s1 = "moshe";
            string s2 = s1;
            s1 = "moshe choen";
            s2 = "klum";
            
            //Heap
            Program p = new Program();

            //Boxing And Unboxing
            int i = 1;
            object o = i; // boxing  
            int j = (int)o; // unboxing  

            //Array in Heap
            int[] ints = { 1, 2, 3, 4 };
            int[] ints2 = ints;

            int[] arr2 = new int[ints.Length];//arr.Length = 4;
            for (int jj = 0; jj < arr2.Length; jj++)
            {
                int currentValue = ints[jj];//1,2
                arr2[jj] = currentValue;//1,2
            }

            arr2[2] = 17;
            #endregion

            #region Method Overloading

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString());

            #endregion


        }
    }
}
