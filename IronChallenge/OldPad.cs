using System;
using System.Collections.Generic;
using System.Text;

namespace IronChallenge
{
    public class OldPad
    {
        private char[][] phoneKeypad;

        public OldPad()
        {
            // Initialize the phone keypad matrix
            phoneKeypad = new char[][]
            {
            new char[] { '&','(','1' },
            new char[] { 'A', 'B', 'C', '2' },
            new char[] { 'D', 'E', 'F', '3' },
            new char[] { 'G', 'H', 'I', '4' },
            new char[] { 'J', 'K', 'L', '5' },
            new char[] { 'M', 'N', 'O', '6' },
            new char[] { 'P', 'Q', 'R', 'S', '7' },
            new char[] { 'T', 'U', 'V', '8' },
            new char[] { 'W', 'X', 'Y', 'Z', '9' }
            };
        }

        public string OldPhonePad(string input)
        {
            
            StringBuilder outputBuilder = new StringBuilder();
            int buttonPressCount = 0;
            char prevButton =' ';
            int charIndex;
           

            if (string.IsNullOrEmpty(input) || input.Length < 2 || input[input.Length - 1] != '#')
                return ""; // Invalid input, return empty string

            foreach (char c in input)
            {

                if (c == '*')
                {
                    if (outputBuilder.Length > 0)
                    {
                        while (outputBuilder.Length > 0 && outputBuilder[outputBuilder.Length - 1] == prevButton)
                        {
                            outputBuilder.Length--;
                            buttonPressCount--;
                        }
                        outputBuilder.Length--;
                        buttonPressCount--;
                        prevButton = ' ';
                    }
                }
                else if (char.IsDigit(c)) // check the number 
                {
                    int buttonIndex = c - '0';
                   // Console.Write(buttonIndex);
                    char[] buttonChars = phoneKeypad[buttonIndex-1];

                    if (c == prevButton)
                    {
                       
                        buttonPressCount++;
                        charIndex = (buttonPressCount - 1) % buttonChars.Length;
                        outputBuilder.Length--;
                        outputBuilder.Append(buttonChars[charIndex]);
                      
                    }
                    else
                    {
                        outputBuilder.Append(buttonChars[0]);
                        buttonPressCount = 1;
                    }

                    prevButton = c;
                    
                }
                else if (c == ' ')
                {
                    outputBuilder.Append(" ");
                    buttonPressCount = 0;
                    prevButton = ' ';
                  
                }
                
            }

            return outputBuilder.ToString();
        }
    }
}

