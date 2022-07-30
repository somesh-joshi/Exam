using System;
using System.Globalization;


class Program {

    public static void Main(String[] args) {
        int k = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        var steak = 0;
        var count = 0;
        for(int i=2; i<=n; i++){
            int x = i;
            steak = 0;
            for(int j=1; j<=x; j++){
                if(x % j != 0)
                    break;
                x++;
                steak++;
            }
            if(steak == k)
              count++;
        }
		Console.WriteLine(count);
	}
}