using System;
using System.Collections.Generic;

class Program {

    public static void Main(String[] args) {
        int[] arr = new int[50];
        Console.WriteLine("Enter the number of elements in an array"); 
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements in an array");
        for(int i=0;i<n;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        int min = arr[0];
        for(int i=1; i<n; i++) {
            if(arr[i]>max) {
            max = arr[i];
         }
         if(arr[i]<min) {
            min = arr[i];
         }
      }
      Console.Write("Largest element is {0}\n", max);
      Console.Write("Smallest element is {0}\n", min);
    }
}