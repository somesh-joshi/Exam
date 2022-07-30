using System;
class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int[] a = new int[5];
        int check = 0, sum = 0;

        for(int i=0;i<5;i++)
        {
            Console.WriteLine("Enter the subject{0} mark", i+1);
            a[i] = Convert.ToInt32(Console.ReadLine());
            sum += a[i];
            if(a[i] == 2)
            {
                Console.WriteLine("No");
                check = 1;
                break;
            }
        }
        sum /= 5;
        if(check == 0 && sum < 4)
            Console.WriteLine("No");
        else if(check == 0 && sum >=4)
            Console.WriteLine("Yes");

    }
}