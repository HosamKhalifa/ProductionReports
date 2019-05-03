using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public class SecurityStore
    {
        public enum WordType { Weak,Meduim,Strong,Perfect}
        private static string GetPermittedChars(char _charVal, WordType _type)
        {
            string reChar="";
            int val = int.Parse(_charVal.ToString());
            switch (val)
            {
                case 0:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "f";
                            break;
                        case WordType.Meduim:
                            reChar = @"\";
                            break;
                        case WordType.Strong:
                            reChar = "r";
                            break;
                        case WordType.Perfect:
                            reChar = "=";
                            break;
                    }
                    break;
                case 1:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "z";
                            break;
                        case WordType.Meduim:
                            reChar = "}";
                            break;
                        case WordType.Strong:
                            reChar = "W";
                            break;
                        case WordType.Perfect:
                            reChar = "E";
                            break;
                    }
                    break;
                case 2:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "K";
                            break;
                        case WordType.Meduim:
                            reChar = "o";
                            break;
                        case WordType.Strong:
                            reChar = ">";
                            break;
                        case WordType.Perfect:
                            reChar = "~";
                            break;
                    }
                    break;
                case 3:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "U";
                            break;
                        case WordType.Meduim:
                            reChar = "n";
                            break;
                        case WordType.Strong:
                            reChar = "@";
                            break;
                        case WordType.Perfect:
                            reChar = "#";
                            break;
                    }
                    break;
                case 4:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "D";
                            break;
                        case WordType.Meduim:
                            reChar = "i";
                            break;
                        case WordType.Strong:
                            reChar = "*";
                            break;
                        case WordType.Perfect:
                            reChar = "!";
                            break;
                    }
                    break;
                case 5:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "g";
                            break;
                        case WordType.Meduim:
                            reChar = "%";
                            break;
                        case WordType.Strong:
                            reChar = "A";
                            break;
                        case WordType.Perfect:
                            reChar = "-";
                            break;
                    }
                    break;
                case 6:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "V";
                            break;
                        case WordType.Meduim:
                            reChar = "m";
                            break;
                        case WordType.Strong:
                            reChar = "?";
                            break;
                        case WordType.Perfect:
                            reChar = "\"";
                            break;
                    }
                    break;
                case 7:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "y";
                            break;
                        case WordType.Meduim:
                            reChar = "$";
                            break;
                        case WordType.Strong:
                            reChar = "s";
                            break;
                        case WordType.Perfect:
                            reChar = "b";
                            break;
                    }
                    break;
                case 8:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "x";
                            break;
                        case WordType.Meduim:
                            reChar = ",";
                            break;
                        case WordType.Strong:
                            reChar = "C";
                            break;
                        case WordType.Perfect:
                            reChar = "p";
                            break;
                    }
                    break;
                case 9:
                    switch (_type)
                    {
                        case WordType.Weak:
                            reChar = "h";
                            break;
                        case WordType.Meduim:
                            reChar = "J";
                            break;
                        case WordType.Strong:
                            reChar = "L";
                            break;
                        case WordType.Perfect:
                            reChar = "q";
                            break;
                    }
                    break;

                
            }
            return reChar;
        }

        public static string Blend(string _input)
        {
            var category = GetWordType(_input);
            string outPut = "";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(_input);
            string byteTxt = "";
            foreach (byte b in asciiBytes)
            {
                byteTxt += b.ToString();
            }
            var byteTxtArray = byteTxt.ToList<char>();
            var interpretedList = new List<string>();
            for (int i = 0; i < byteTxtArray.Count-1; i++)
            {
                interpretedList.Add(GetPermittedChars(byteTxtArray[i], category));
            }
            outPut = string.Join("",interpretedList.ToArray());
            return GlobalMethods.EncryptPwd( outPut);
        }
        private static WordType GetWordType(string _word)
        {
           if(_word.Length <= 4)
            {
                return WordType.Weak;
            }
            else if (_word.Length <=7)
            {
                return WordType.Meduim;
            }
            else if(_word.Length <=9)
            {
                return WordType.Strong;
            }
            else
            {
                return WordType.Perfect;
            }
        }

   }
}
