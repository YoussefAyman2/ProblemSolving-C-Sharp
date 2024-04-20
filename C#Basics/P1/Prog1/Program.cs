using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace Prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*
             bool Flag;
             int Num;
             do
             {
                 Console.Write("Enter a Number: ");
                 Flag = int.TryParse(Console.ReadLine(), out Num);
                 if (Flag)
                 {
                     Console.WriteLine(Num);
                 }
             } while (!Flag);
            */
            #endregion

            #region Question2
            /*
            int num;
            bool flag;
            do
            {
                Console.Write("Enter a Number: ");
                flag = int.TryParse(Console.ReadLine(), out num);
                if (flag) {
                    if (num % 3 == 0 || num % 4 == 0 || num == 0)
                    {
                        Console.Write("Yes");
                    }
                    else {
                        Console.Write("No");
                    }
                }
            } while (!flag);
            */
            #endregion

            #region Question3
            /*
            int num01, num02;
            Console.Write("Enter First Number: ");
            while (!int.TryParse(Console.ReadLine(), out num01)) {
                Console.Write("Enter First Number: ");
            }
            Console.Write("Enter Second Number: ");
            while (!int.TryParse(Console.ReadLine(), out num02))
            {
                Console.Write("Enter Second Number: ");
            }
            String Msg = num01 == num02 ? "Equals" : num01 > num02 ? Convert.ToString(num01) : Convert.ToString(num02);
            Console.WriteLine(Msg);
            */
            #endregion

            #region Question4
            /*
            int num;
            Console.Write("Enter Number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Enter Number: ");
            }
            string Msg = num == 0 ? "Zero" :num>0?"Positive": "Negative";
            Console.Write(Msg);
            */
            #endregion

            #region Question5
            /*
            int min, max,num01,num02,num03;
            Console.Write("Enter First Number: ");
            while (!int.TryParse(Console.ReadLine(), out num01))
            {
                Console.Write("Enter First Number: ");
            }
            Console.Write("Enter Second Number: ");
            while (!int.TryParse(Console.ReadLine(), out num02))
            {
                Console.Write("Enter Second Number: ");
            }
            Console.Write("Enter Third Number: ");
            while (!int.TryParse(Console.ReadLine(), out num03))
            {
                Console.Write("Enter Third Number: ");
            }
            max = num01 >= num02 ? num01 >= num03 ?num01:num03:num02>=num03?num02:num03;
            min = num01 <= num02 ? num01 <= num03 ? num01 : num03 : num02 <= num03 ? num02 : num03;
            Console.WriteLine("Max = "+max);
            Console.WriteLine("Min = "+min);
            */
            #endregion

            #region Question6
            /*
            int num;
            String Msg;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out num)) {
                Console.Write("Enter a Number: ");
            }
            Msg = num == 0 ? "Zero" :num%2==0?"Even":"Odd";
            Console.WriteLine(Msg);
            */
            #endregion

            #region Question7
            /*
            char C;
            string Msg;
            Console.Write("Enter a Char: ");
            while (!char.TryParse(Console.ReadLine(), out C))
            {
                Console.Write("Enter a Char: ");
            }
            C = Char.ToLower(C);
            Msg = (C == 'a' || C == 'e' || C == 'i' || C == 'o' || C == 'u') ? "vowel" : "consonant";
            Console.WriteLine(Msg);
            */
            #endregion

            #region Question8
            /*
            int num;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out num)) {
                Console.Write("Enter a Number: ");
            }
            for (int i = 1; i <= num; i++) {
                Console.Write(i+"\t");
            }
            */
            #endregion

            #region Question9
            /*
            int num;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Enter a Number: ");
            }
            for (int i = 1; i <= 12; i++) {
                Console.Write(i*num+" ");
            }
            */
            #endregion

            #region Question10
            /*
            int num;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Enter a Number: ");
            }
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 == 0) {
                    Console.Write(i+" ");
                }
            }
            */
            #endregion

            #region Question11
            /*
            int num, pow;
            double result=1.0;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Enter a Number: ");
            }
            Console.Write("Enter a Power: ");
            while (!int.TryParse(Console.ReadLine(), out pow))
            {
                Console.Write("Enter a Power: ");
            }
            if (pow > 0)
            {
                for (int i = 0; i < pow; i++)
                {
                    result *= num;
                }
            }
            else{
                for (int i = pow; i < 0; i++)
                {
                    result *= 1.0/num;
                }

            }

            Console.WriteLine(result);
            Console.WriteLine(Math.Pow(num,pow));
            */
            #endregion

            #region Question12
            /*
            int[] Marks = new int[5];
            int Sum = 0;
            for (int i = 0; i < Marks.Length; i++) {
                Console.Write("Enter Mark in Subject Number ["+(i+1)+"]: ");
                while (!int.TryParse(Console.ReadLine(), out Marks[i])) {
                    Console.Write("Enter Mark in Subject Number [" + (i + 1) + "]: ");
                }
            }
            for (int i = 0; i < Marks.Length; i++) { 
                Sum+= Marks[i];
            }
            int Avg = Sum / Marks.Length;
            float Percent = ( Sum /(float) (Marks.Length * 100))*100;
            Console.WriteLine("Avg = "+Avg);
            Console.WriteLine("Percent = "+Percent);
            */
            #endregion

            #region Question13
            /*
            int MonthNum;
            string Msg="Days in Month: ";
            Console.Write("Enter Month Number: ");
            bool flag = int.TryParse(Console.ReadLine(), out MonthNum);
            if (!(MonthNum>0&&MonthNum<=12&&flag)) {
                Console.Write("Enter Month Number: ");
                while (!int.TryParse(Console.ReadLine(), out MonthNum)){
                    Console.Write("Enter Month Number: ");
                }
            }
            switch (MonthNum)
            {
                case 2:Msg += "28 or (29 if leap year)";break;
                case 4:
                case 9:
                case 6:
                case 11:
                    Msg += "30";break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Msg += "31";break;
            }
            Console.WriteLine(Msg);
            */
            #endregion

            #region Question14
            /*
            int[] Marks = new int[5];
            char[] Grades = new char[Marks.Length];
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write("Enter Mark in Subject Number [" + (i + 1) + "]: ");
                while (!int.TryParse(Console.ReadLine(), out Marks[i]))
                {
                    Console.Write("Enter Mark in Subject Number [" + (i + 1) + "]: ");
                }
            }
            for (int j = 0; j < Marks.Length; j++) {
                Grades[j] = Marks[j] >= 90 ? 'A' : Marks[j] >= 80 ? 'B' : Marks[j] >= 70 ? 'C' : Marks[j] >= 60 ? 'D' : Marks[j] >= 50 ? 'E' : 'F';
            }
            for (int k = 0; k < Marks.Length; k++) {
                Console.WriteLine($"Subject Number[{(k+1)}]: {Marks[k]} , Grade = {Grades[k]}");
            }
            */
            #endregion

            #region Question15
            //same as 4
            #endregion

            #region Question16

            //float Num01, Num02,Result=0;
            //char Ope;  
            //Console.Write("Enter First Number: ");
            //while(!Single.TryParse(Console.ReadLine(),out Num01))
            //{
            //    Console.Write("Enter First Number: ");
            //}
            //Console.Write("Enter Second Number: ");
            //while (!Single.TryParse(Console.ReadLine(), out Num02))
            //{
            //    Console.Write("Enter Second Number: ");
            //}
            //Console.Write("Enter Opeartion (+ - / * %): ");
            //while (!char.TryParse(Console.ReadLine(),out Ope)) {
            //    Console.Write("Enter Opeartion (+ - / * %): ");
            //}

            //switch (Ope) {
            //    case '+':Result=Num01+Num02; break;
            //    case '-': Result = Num01 + Num02; break;
            //    case '/': Result = Num01 / Num02; break;
            //    case '*': Result = Num01 * Num02; break;
            //    case '%': Result = Num01 % Num02; break;
            //}
            //if (Ope == '+' || Ope == '-' || Ope == '/' || Ope == '*' || Ope == '%')
            //{
            //    Console.WriteLine($"Equation is {Num01} {Ope} {Num02} = {Result}");
            //}
            //else {
            //    Console.WriteLine("Invalid Operator Input.");
            //}

            #endregion

            #region Question17
            /*
            string Name = "Amr";
            string ReversedName = "";
            for (int i = Name.Length-1; i >= 0; i--) {
                ReversedName += Name[i];
            }
            Console.WriteLine(ReversedName);
            */
            /*
            string S;
            Console.Write("Enter Sting: ");
            S=Console.ReadLine();
            char[] r =S.ToCharArray();
            Array.Reverse(r);
            Console.WriteLine(r);
            */
            #endregion

            #region Question18
            /*
            int number;
            Console.Write("Enter a Number: ");
            while (!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Enter a Number: ");
            }
            char[] Arr=number.ToString().ToCharArray();
            Array.Reverse(Arr);
            Console.WriteLine(Arr);
            */
            #endregion

            #region Question19
            /*
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum=0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            Console.WriteLine($"Sum Of Element Of Array = {sum}");
            */
            #endregion

            #region Question20
            //int s;
            //Console.Write("Enter Array Size: ");
            //while (!int.TryParse(Console.ReadLine(), out s))
            //{
            //    Console.Write("Enter Array Size: ");
            //}
            //int[] arr01 = new int[s];
            //int[] arr02 = new int[s];
            //int[] arr03 = new int[s];
            //int Mark = 1;
            //int ctr = 0; 
            //for (int i = 0; i < s; i++)
            //{
            //    Console.Write($"Arr[{(i + 1)}]: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr01[i]))
            //    {
            //        Console.Write($"Arr[{(i + 1)}]: ");
            //    }
            //}
            //for (int i = 0; i < s; i++)
            //{
            //    arr02[i] = arr01[i];
            //    arr03[i] = 0;
            //}
            //for (int i = 0; i < s; i++) {
            //    for (int j = 0; j < s; j++) {
            //        if (arr01[i] == arr02[j])
            //        {
            //            arr03[j] = Mark;
            //            Mark++;
            //        }
            //    }
            //    Mark = 1;
            //}
            //for (int i = 0; i < s; i++) {
            //    if (arr03[i] == 2) {
            //        ctr++;
            //    }
            //}
            //Console.WriteLine($"Total Number of Duplicate = {ctr}");
            #endregion

            #region Question21
            //int[] arr01 = new int[5] { 5,6,7,8,9 };
            //int[] arr02 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] ConcatArray = new int[arr01.Length * 2];
            //bool flag = true;
            //for (int i = 0; i < ConcatArray.Length/2; i++)
            //{
            //    if (i < 5&&flag)
            //    {
            //        ConcatArray[i] = arr01[i];
            //        if (i == 4) {
            //            flag = false;
            //            i = 0;
            //        }
            //    }
            //    else {
            //        ConcatArray[i+arr01.Length] = arr02[i];
            //    }
            //}
            //Array.Sort(ConcatArray);
            //foreach (int i in ConcatArray)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Question22
            //int[] arr = { 0,1,1,0,1 };
            //int[] fr = new int[arr.Length];
            //int visited = -1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            fr[j] = visited;
            //        }
            //    }
            //    if (fr[i] != visited)
            //        fr[i] = count;
            //}
            //Console.WriteLine("---------------------");
            //Console.WriteLine(" Element | Frequency");
            //Console.WriteLine("---------------------");
            //for (int i = 0; i < fr.Length; i++)
            //{
            //    //if (fr[i] != visited)
            //        Console.WriteLine("    " + arr[i] + "    |    " + fr[i]);
            //}
            //Console.WriteLine("---------------------");
            #endregion

            #region Question23
            //int[] arr01 = { 1, 2, 3,-5,150, 200, 4, 0, 0, 0, 20, 30, 150 };
            //int Max = arr01[0];
            //int Min = arr01[0];
            //for (int i = 0; i < arr01.Length; i++) {
            //    if (Max < arr01[i]) {
            //        Max = arr01[i];
            //    }
            //    if (Min > arr01[i]) { 
            //    Min = arr01[i]; 
            //    }
            //}
            //Console.WriteLine($"Min Number = {Min}, Max Number = {Max}");
            //Another Solution
            //Array.Sort(arr01);
            //Console.WriteLine($"Min Number = {arr01[0]}, Max Number = {arr01[arr01.Length-1]}");
            #endregion

            #region Question24
            //int[] arr01 = { 1, 2, 3,-5, 200, 4, 0, 0, 0, 20, 30, 150 };
            //Array.Sort(arr01);
            //Console.WriteLine($"Second Max Number = {arr01[arr01.Length-2]}");
            #endregion

            #region Question25
            //int Size;
            //Console.Write("Enter Array Size: ");
            //while (!int.TryParse(Console.ReadLine(), out Size))
            //{
            //    Console.Write("Enter Array Size: ");
            //}
            //int[] arr01 = new int[Size];
            //int[] arr02 = new int[arr01.Length];
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Arr[{i}]: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr01[i]))
            //    {
            //        Console.Write($"Arr[{i}]: ");
            //    }
            //}
            //if (Size > 0)
            //{
            //    Console.Write("Array: [");
            //    for (int i = 0; i < Size; i++)
            //    {
            //        if (i != Size - 1)
            //        {
            //            Console.Write($"{arr01[i]},");
            //        }
            //        else
            //        {
            //            Console.Write($"{arr01[i]}");

            //        }
            //    }
            //    Console.WriteLine("]");
            //}
            //int zeroIndexCells = Array.LastIndexOf(arr01, 0) - Array.IndexOf(arr01, 0) - 1;
            //if (zeroIndexCells != -1)
            //{
            //    Console.WriteLine($"The Number Of Cells Between Frist and Last(0) = {zeroIndexCells}");
            //}
            //int Index;
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Index = Array.LastIndexOf(arr01, arr01[i]);
            //    if (Index != i)
            //    {
            //        if (Array.IndexOf(arr02, arr01[i]) == -1)
            //        {
            //            Console.WriteLine($"The Number Of Cells Between Frist and Last({arr01[i]}) = {Index - i - 1}");
            //            arr02[i] = arr01[i];
            //        }
            //    }
            //}

            #endregion

            #region Question26
            /* // reverse every word in it's place
            Console.Write("Enter a Text: ");
            String Text=Console.ReadLine();
            string[] arr01 = Text.Split(" ");
            char[] str; 
            for (int i = 0; i < arr01.Length; i++) { 
                str= arr01[i].ToCharArray();
                Array.Reverse(str);
                arr01[i] = "";
                for (int j = 0; j < str.Length; j++)
                {
                    arr01[i] += str[j];
                }
            }
            foreach (string s in arr01) {
                Console.Write(s+" ");
            }*/
            //Second Solution 
            Console.Write("Enter a Text: ");
            String Text = Console.ReadLine();
            string[] arr01 = Text.Split(" ");
            if (arr01.Length > 1)
            {
                Array.Reverse(arr01);
            }
            else
            {
                Console.WriteLine(arr01[0]);
            }
            for (int i = 0; i < arr01.Length && arr01.Length > 1; i++)
            {
                Console.Write(arr01[i] + " ");
            }
            #endregion
        }
    }
}
