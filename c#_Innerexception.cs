﻿using System;
using System.IO;

namespace Hitler
{
    class ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());


                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Sample Files\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem! Plese try later");
                    }
                    else
                    {
                        //To retain the original exception pass it as a parameter
                        //to the constructor, of the current exception
                        throw new Exception(filePath + " Does not Exist", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                //ex.Message will give the current exception message
                Console.WriteLine("Current or Outer Exception = " + ex.Message);


                //Check if inner exception is not null before accessing Message property
                //else, you may get Null Reference Excception
               if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", ex.InnerException.Message);
                }
            }
            Console.ReadLine();
        }
    }
}