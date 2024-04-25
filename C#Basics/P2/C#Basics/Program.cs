namespace C_Basics
{
    internal class Program
    {
        #region Question1
        public static int[] SumSub(int num01, int num02)
        {
            return new int[] { num01 + num02, num01 - num02 };
        }
        public static void SumSub(int num01, int num02, out int Sum, out int Sub)
        {
            Sum = num01 + num02;
            Sub = num01 - num02;
        }
        public struct Data { 
        public float sum;
        public float sub;
        }
        public static Data SumSub(float num01, float num02)
        {
            Data D=new Data();
            D.sub = num01-num02;
            D.sum = num01+num02;
            return D;
        }
        #endregion
        #region Question2
        [Flags] 
        enum Permissions : byte
        {
            Delete = 1, Execute = 2, Write = 4, Read = 8
        }

        #endregion
        public static void Main(string[] args) 
        {
            #region TestQ1
            /*
            int x = 20, y = 10;
            SumSub(x, y, out int Sum, out int Sub);
            Console.WriteLine($"Sum={Sum},Sub={Sub}");
            int[] arr = new int[2];
            arr = SumSub(5,10);
            Console.WriteLine($"Sum={arr[0]},Sub={arr[1]}");
            Data d;
            d = SumSub(  10.5F, 30.5F);
            Console.WriteLine($"Sum={d.sum},Sub={d.sub}");
            */
            #endregion

            #region TestQ2
            Permissions MyP = Permissions.Read;
            //Console.WriteLine(MyP);

            MyP = (Permissions)3;
            Console.WriteLine(MyP);// Delete, Execute

            //// If You Want To Add Permission, Do OR Operation
            ///lw 3ayez tzwd permission 
            MyP |= Permissions.Read;//or bit wise operation  3(0011|0100)=(0111)=7

            Console.WriteLine(MyP);// Delete, Execute, Read

            //// If You Want To Remove (Deny) Permission, Do NAND Operation

            MyP = MyP & (~Permissions.Read);

            Console.WriteLine(MyP);// Delete, Execute

            // If You Want To Add Permission, Do XOR Operation 
            //Toggle lw 3ndo el permission da shelo we el 3ks
            MyP ^= Permissions.Write;
            Console.WriteLine(MyP); // Delete, Execute, Write

            // If You Want To Remove (Deny) Permission, Do XOR Operation
            MyP ^= Permissions.Execute;
            Console.WriteLine(MyP); // Delete, Write

            // Check Read Permission is existed inside MyP
            if ((MyP & Permissions.Read) == Permissions.Read)
                Console.WriteLine("Read Existed");
            else
                Console.WriteLine("Read Not Existed"); 
            #endregion


        }
    }
}
