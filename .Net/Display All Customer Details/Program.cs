using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("Customer Details");
            int choice;
            do
            {
                Console.WriteLine("Menu\n1.Attributes\n2.Methods\n3.Constructor\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                //Fill your code here
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Attributes present in Customer class");
                        //Fill your code here
                        PropertyInfo[] propertyInfos = typeof(Customer).GetProperties();
                        foreach (var prop in propertyInfos)
                        {
                            string s = Convert.ToString(prop.PropertyType);
                            Console.WriteLine(s.Substring(s.IndexOf(".") + 1) + " " + prop.Name);
                        };
                        break;
                    case 2:
                        Console.WriteLine("Methods present in Customer class");
                        //Fill your code here
                        MethodInfo[] methodInfos = typeof(Customer).GetMethods();
                        foreach(var prop in methodInfos)
                        {
                            string s = Convert.ToString(prop.ReturnType);
                            Console.WriteLine(s.Substring(s.IndexOf(".") + 1) + " "+prop.Name);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Constructors present in Customer class");
                        //Fill your code here
                        ConstructorInfo[] constructorInfos = typeof(Customer).GetConstructors();
                        foreach (var prop in constructorInfos)
                        {
                            string s = "";
                            string k = "";
                            ParameterInfo[] parameters = prop.GetParameters();
                            foreach(ParameterInfo param in parameters)
                            {
                                string g = Convert.ToString(param.ParameterType.Name)+", ";
                                k= k + g;
                                s = k;
                                s=s.Remove(s.Length-2,2);
                            }
                            
                            Console.WriteLine("Void .ctor("+s+")");
                        }

                        break;
                    case 4:
                        break;
                }
            } while (choice > 0 && choice < 4);
            //Console.Read();
        }
}