﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("33#")); // E
            Console.WriteLine(OldPhonePad("227*#")); // B
            Console.WriteLine(OldPhonePad("4433555 555666#")); // HELLO
            Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        }

        public static String OldPhonePad(string input)
        {
            List<char> charList = new List<char>();
            string output = "";
            string[] substrings = input.Split(' ');
            foreach (string substring in substrings)
            {
                // Console.WriteLine(substring);
                string[] sublist = divide(substring);
                foreach (string miniSubstring in sublist)
                {
                    // Console.WriteLine(miniSubstring);
                    char tempChar = converter(miniSubstring);
                    // Console.WriteLine(tempChar);
                    if (tempChar == '*' && charList.Count > 0)
                    {
                        charList.RemoveAt(charList.Count - 1);
                    }
                    else if (tempChar != '#')
                    {
                        charList.Add(converter(miniSubstring));
                    }
                }
                // Console.WriteLine("------------------");
            }
            foreach (char outChar in charList)
            {
                output = output + outChar;
            }
            return output;
        }

        public static string[] divide(string input)
        {
            if (input.Length <= 1)
            {
                string[] theout = { input };
                return theout;
            }
            string[] output = [];
            string tempOutput = "";
            int count = 0;
            char tempChar = '.';
            string tempString = "";
            foreach (char item in input)
            {
                // Console.WriteLine("Item: "+item);
                if (count == 0)
                {
                    tempChar = item;
                    tempString = tempString + tempChar;
                }
                else
                {
                    if (item == tempChar)
                    {
                        tempString = tempString + item;
                        // Console.WriteLine("Temp String: "+tempString);
                    }
                    else
                    {
                        if (tempOutput.Length <= 0)
                        {
                            tempOutput = tempString;
                        }
                        else
                        {
                            tempOutput = tempOutput + ' ' + tempString;
                        }
                        tempString = "" + item;
                    }
                    tempChar = item;
                }
                count++;
            }
            tempOutput = tempOutput + ' ' + tempString;
            output = tempOutput.Split(' ');
            // foreach (string substring in output)
            // {
            //     Console.WriteLine(substring);
            // }
            return output;
        }

        public static char converter(string input)
        {
            if (input.Length <= 0)
            {
                return '.';
            }
            if (input[0] == '2')
            {
                if (input.Length == 1)
                {
                    return 'A';
                }
                if (input.Length == 2)
                {
                    return 'B';
                }
                if (input.Length == 3)
                {
                    return 'C';
                }
            }
            if (input[0] == '3')
            {
                if (input.Length == 1)
                {
                    return 'D';
                }
                if (input.Length == 2)
                {
                    return 'E';
                }
                if (input.Length == 3)
                {
                    return 'F';
                }
            }
            if (input[0] == '4')
            {
                if (input.Length == 1)
                {
                    return 'G';
                }
                if (input.Length == 2)
                {
                    return 'H';
                }
                if (input.Length == 3)
                {
                    return 'I';
                }
            }
            if (input[0] == '5')
            {
                if (input.Length == 1)
                {
                    return 'J';
                }
                if (input.Length == 2)
                {
                    return 'K';
                }
                if (input.Length == 3)
                {
                    return 'L';
                }
            }
            if (input[0] == '6')
            {
                if (input.Length == 1)
                {
                    return 'M';
                }
                if (input.Length == 2)
                {
                    return 'N';
                }
                if (input.Length == 3)
                {
                    return 'O';
                }
            }
            if (input[0] == '7')
            {
                if (input.Length == 1)
                {
                    return 'P';
                }
                if (input.Length == 2)
                {
                    return 'Q';
                }
                if (input.Length == 3)
                {
                    return 'R';
                }
                if (input.Length == 4)
                {
                    return 'S';
                }
            }
            if (input[0] == '8')
            {
                if (input.Length == 1)
                {
                    return 'T';
                }
                if (input.Length == 2)
                {
                    return 'U';
                }
                if (input.Length == 3)
                {
                    return 'V';
                }
            }
            if (input[0] == '9')
            {
                if (input.Length == 1)
                {
                    return 'W';
                }
                if (input.Length == 2)
                {
                    return 'X';
                }
                if (input.Length == 3)
                {
                    return 'Y';
                }
                if (input.Length == 4)
                {
                    return 'Z';
                }
            }
            if (input[0] == '*')
            {
                return '*';
            }
            if (input[0] == '#')
            {
                return '#';
            }
            return 'A';
        }
    }
}
