using System;
class groovy{
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] l = new int[n];
        String[] m = Console.ReadLine().Split(' ');
        for (var i = 0; i < n; i++)
        {
            l[i] = int.Parse(m[i]);
        }
        int s = 0;
        for(int i=0;i<n;i++){
            s += Math.Min(l[i],l[i+1]);
            i++;
        }
        Console.WriteLine(s);
    }
}
