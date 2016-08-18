using System;
using System.Collections.Generic;

using System.Text;


namespace TryMeprojects
{
    class Program
    {
        static void Main(string[] args)
        {
           OptionalParameter. OptionalParameterMethod(20,"prasanna");
        }
       
    }
    public class OptionalParameter
    {
       public static void OptionalParameterMethod(int Cal, string Name = "No Name", bool IsEdit = false)
        {

            Console.WriteLine("Print Values:{0} Name: {1} Edit: {2}", Cal, Name, IsEdit);
        }
    }
}
