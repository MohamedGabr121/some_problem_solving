using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace C__Problem
{
	internal class Program
	{
		public static string AddIfToFront(string text)
		{
			if (text.StartsWith("if"))
			{
				return text;
			}
			return "if " + text;
		}

		public static string ExchangeFirstAndLastCharacters(string text)
		{
			if (text.Length <= 1)
			{
				return text;
			}
			char firstChar = text[0];
			char lastChar = text[text.Length - 1];

			return lastChar + text.Substring(1, text.Length - 2) + firstChar;
		}

		public static string CreateCopiesOfFrontCharacters(string text)
		{
			if (text.Length < 2)
			{
				// String length is less than 2, return the original string
				return text;
			}

			string frontChars = text.Substring(0, 2);
			return frontChars + frontChars + frontChars + frontChars;
		}

		public static string AddedWtihFirstAndLastString(string str)
		{
			if (str.Length >= 1)
			{
				char lastChar = str[str.Length - 1];
				return lastChar + str + lastChar;
			}
			return str;
		}

		public static bool CheckNumberOfPositiveAndmultipleOf3Or7(int number)
		{
			if (number % 3 == 0 || number % 7 == 0)
			{
				return true;
			}
			return false;
		}

		public static string AddFirstThreeCharacters(string str)
		{
			if (str.Length < 3)
			{
				return str + str + str;
			}

			string firstThreeChars = str.Substring(0, 3);
			return firstThreeChars + str + firstThreeChars;
		}

		public static bool StringStartWithCSharp(string str)
		{
			if (str.StartsWith("C#"))
			{
				return true;
			}
			return false;
		}

		public static bool CheckTemperatureIsLessThanZeroAndAnotherIsGreatetThan100(int number1, int number2)
		{
			if ((number1 < 0 || number2 < 0) && (number2 > 100 || number1 > 100))
			{
				return true;
			}
			return false;
		}

		public static bool CheckTwoNumberIsRange100And200(int number1, int number2)
		{
			if ((number1 >= 100 && number1 <= 200) || (number2 >= 100 && number2 <= 200))
			{
				return true;
			}
			return false;
			static bool CheckTwoNumberIsRange100And200(int number1, int number2)
			{
				if ((number1 >= 100 && number1 <= 200) || (number2 >= 100 && number2 <= 200))
				{
					return true;
				}
				return false;
			}
		}

		public static bool CheckThreeNumberIsRange20And50(int number1, int number2, int number3)
		{
			if ((number1 >= 100 && number1 <= 200) || (number2 >= 100 && number2 <= 200) || (number3 >= 20 && number3 <= 50))
			{
				return true;
			}
			return false;

		}

		public static bool CkeckNumberInRange20To50(int x, int y)
		{
			return (x <= 20 || y >= 50) || (y <= 20 || x >= 50);
		}
		public static string RemoveYtAtIndex1(string str)
		{
			if (str.Length > 1 && str.Substring(1, 2) == "yt")
			{
				return str.Remove(1, 2);
			}
			return str;
		}

		public static int CheckNumberLargest(int number1, int number2, int number3)
		{
			if (number1 >= number2 && number1 >= number3)
			{
				return number1;
			}
			else if (number2 >= number1 && number2 >= number3)
			{
				return number2;
			}
			else { return number3; }
		}

		public static int CheckNumberIsClosest100(int num1, int num2)
		{
			if (num1 == num2)
			{
				return 0;
			}
			int diff1 = Math.Abs(num1 - 100);
			int diff2 = Math.Abs(num2 - 100);

			if (diff1 < diff2)
			{
				return num1;
			}
			else
			{
				return num2;
			}
		}

		public static bool CkeckNumberInRange40To50(int num1, int num2)
		{
			bool isNum1InRange = num1 >= 20 && num1 <= 50;
			bool isNum2InRange = num2 >= 20 && num2 <= 50;
			if (isNum1InRange || isNum2InRange)
			{
				return true;
			}
			return false;
		}

		public static int CheckNumberInRange20To30(int num1, int num2)
		{
			bool isNum1InRange = num1 >= 20 && num1 <= 30;
			bool isNum2InRange = num2 >= 20 && num2 <= 30;
			if (isNum1InRange || isNum2InRange)
			{
				return Math.Max(num1, num2);
			}
			else if (isNum1InRange)
			{
				return num1;
			}
			else if (isNum2InRange)
			{
				return num2;
			}
			else
			{
				return 0;
			}

		}

		public static bool CheckStringContainsBetween2To4ZCharacters(string str)
		{
			int count = 0;

			foreach (char c in str)
			{
				if (c == 'z' || c == 'Z')
				{
					count++;
				}
			}

			return count >= 2 && count <= 4;
		}


		public static bool HaveSameLastDigit(int num1, int num2)
		{
			int lastDigit1 = num1 % 10;
			int lastDigit2 = num2 % 10;

			return lastDigit1 == lastDigit2;
		}

		public static string ConvertLast3ToUppercase(string str)
		{
			if (str.Length < 3)
			{
				return str.ToUpper();
			}
			else
			{
				string last3 = str.Substring(str.Length - 3);
				string prefix = str.Substring(0, str.Length - 3);

				return prefix + last3.ToUpper();
			}
		}

		public static string CopiesOfGivenString(string str, int number)
		{
			string result = String.Empty;
			for (int i = 0; i < number; i++)
			{
				result += str;
			}
			return result;
		}

		public static string ExtractString(string str, int startIndex, int length)
		{
			if (startIndex < 0 || startIndex > str.Length)
			{
				return string.Empty;
			}
			int endIndex = startIndex + length - 1;
			endIndex = Math.Min(endIndex, str.Length - 1);

			char[] charArray = new char[endIndex - startIndex + 1];
			int index = 0;

			for (int i = startIndex; i < endIndex; i++)
			{
				charArray[index] = str[i];
				index++;
			}

			string extractedSubstring = new string(charArray);
			return extractedSubstring;
		}

		public static void CheckSubString(string str, string search)
		{


			if (str.Contains(search))
			{
				Console.WriteLine("The substring exists in the string ");
			}

			else
			{
				Console.WriteLine("The substring not exists in the string");

			}

		}

		public static string ReplaceLowercaseCharactersWithUppercase(string str)
		{
			char[] charArray = str.ToCharArray();

			for (int i = 0; i < charArray.Length; i++)
			{
				if (char.IsLower(charArray[i]))
				{
					charArray[i] = char.ToUpper(charArray[i]);
				}
				else if (char.IsUpper(charArray[i]))
				{
					charArray[i] = char.ToLower(charArray[i]);
				}
			}

			string convertString = new string(charArray);

			return convertString;
		}

		public static bool CheckCredentials(string username, string password, string validUsername, string validPassword)
		{
			if (username == validUsername && password == validPassword)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void CheckWhetherACharacterIsAnAlphabet(char character)
		{
			if (char.IsUpper(character))
			{
				Console.WriteLine("The character is uppercase.");
			}
			else
			{
				Console.WriteLine("The character is lowercase.");
			}
		}

		public static void SearchForThePositionOfASubString(string str, string searchString)
		{
			int position = str.IndexOf(searchString);//this is a string
			if (str.Contains(searchString))
			{
				Console.WriteLine($" Found '{searchString}' in 'this is a string' at position {position}");
			}
			else
			{
				Console.WriteLine($" Not Found '{searchString}' in 'this is a string' at position {position}");

			}
		}

		public static void FindTheNumberItemsOfSubCString(string str, string searchString)
		{
			int count = 0;

			if (str.Contains(searchString))
			{
				count++;
				Console.WriteLine($"The string '{str}' occurs {count} times");
			}
			else
			{
				Console.WriteLine($"The string '{str}' Not occurs {count} times");
			}
		}

		public static void SearchStringAndInsertString(string str, string searchString, string insertString)
		{
			int position = str.IndexOf(searchString);
			if (str.Contains(searchString))
			{
				Console.WriteLine($"The modified string is : {str.Insert(position, insertString)} ");
			}
		}

		public static int CompareSubstrings(string str1, string substring1, string str2, string substring2)
		{
			string sub1 = str1.Substring(str1.IndexOf(substring1));//computer
			string sub2 = str2.Substring(str2.IndexOf(substring2));//system

			return String.Compare(sub1, sub2);

		}

		static int CompareSubstrings(string str1, string substring1, string str2, string substring2, bool ignoreCase)
		{
			string sub1 = str1.Substring(str1.IndexOf(substring1));
			string sub2 = str2.Substring(str2.IndexOf(substring2));

			return String.Compare(sub1, sub2, ignoreCase);
		}

		static void CompareSubstrings(string str1, string str2, CultureInfo culture)
		{
			string substr1 = "UT";
			string substr2 = "ut";

			bool equal = string.Compare(substr1, substr2, culture, CompareOptions.IgnoreCase) == 0;

			Console.WriteLine("Ignore case, {0} culture:", culture.DisplayName);
			Console.WriteLine("Substring '{0}' in '{1}' is {2} to substring '{3}' in '{4}'.",
							  substr1, str1, equal ? "equal" : "not equal", substr2, str2);
		}
		static void Main(string[] args)
		{
			/*  Part One Of The Problem Solving In C# ( 1 - 25 ) */

			#region Example1
			//1. Write a C# Sharp program to compute the sum of the two numerical values.
			//If the two values are the same, return triple their sum.

			//int num1 = Convert.ToInt32(Console.ReadLine());
			//int num2 = Convert.ToInt32(Console.ReadLine());
			//if (num1 == num2)
			//{
			//	Console.WriteLine((num1 + num2) * 3);
			//}
			//else
			//{
			//	Console.WriteLine(num1 + num2);
			//}
			#endregion
			#region Example2
			//2.Write a C# Sharp program to get the absolute difference between n and 51. 
			//If n is broader than 51 return triple the absolute difference.

			//int n = Convert.ToInt32(Console.ReadLine());

			//if(n > 51)
			//{
			//	Console.WriteLine((n - 51) * 3);
			//}
			//else
			//{
			//	Console.WriteLine(Math.Abs(n - 51));
			//}
			#endregion
			#region Example3
			//3. Write a C# Sharp program to check two given integers,
			//and return true if one of them is 30 or if their sum is 30.

			//int num1=Convert.ToInt32(Console.ReadLine());
			//int num2=Convert.ToInt32(Console.ReadLine());

			//int sum = num1 + num2;

			//bool result = sum ==30 ? true : false;
			//Console.WriteLine(result);
			#endregion
			#region Example4
			//4. Write a C# Sharp program to check a given integer
			//and return true if it is within 10 of 100 or 200.

			//int number = Convert.ToInt32(Console.ReadLine());
			//bool isWithinRange = (Math.Abs(100 - number) <= 10) || (Math.Abs(200 - number) <= 10);
			//Console.WriteLine(isWithinRange);


			#endregion
			#region ُExample5
			//5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string.
			//If the string already begins with 'if', return it unchanged.

			//string word = Console.ReadLine();
			//string result = AddIfToFront(word);
			//Console.WriteLine(result);
			#endregion
			#region Example6
			//6. Write a C# Sharp program to remove the character at a given position in the string.
			//The given position will be in the range 0..(string length -1) inclusive.

			//string input = Console.ReadLine();
			//int number = int.Parse(Console.ReadLine());
			//Console.WriteLine(input.Remove(number,1));

			#endregion
			#region Example7
			//7. Write a C# Sharp program to exchange the first and last characters in
			//a given string and return the new string.

			//string input = Console.ReadLine();

			//string output = ExchangeFirstAndLastCharacters(input);
			//Console.WriteLine(output);
			#endregion
			#region Eample8
			//8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string.
			//If the given string length is less than 2 return the original string.

			//string input = Console.ReadLine();

			//string result = CreateCopiesOfFrontCharacters(input);

			//Console.WriteLine(result);
			#endregion
			#region Example9
			//9. Write a C# Sharp program to create a string with the last char added
			//at the front and back of a given string of length 1 or more.
			//string str = Console.ReadLine();

			//string result = AddedWtihFirstAndLastString(str);
			//Console.WriteLine(result);

			#endregion
			#region Eaxmple10
			//10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.

			//int number = int.Parse(Console.ReadLine());

			//bool result = CheckNumberOfPositiveAndmultipleOf3Or7(number);
			//Console.WriteLine(result);
			#endregion
			#region Eaxmple11
			//11. Write a C# Sharp program to create a string taking the first 3 characters of a given string.
			//Return the string with the 3 characters added at both the front and back.
			//If the given string length is less than 3, use whatever characters are there

			//string input = Console.ReadLine();

			//string result = AddFirstThreeCharacters(input);

			//Console.WriteLine(result);

			#endregion
			#region Eaxmple12
			//12. Write a C# Sharp program to check if a given string starts with 'C#' or not.

			//string str = Console.ReadLine();

			//bool res = StringStartWithCSharp(str);

			//Console.WriteLine(res);
			#endregion
			#region Eaxmple13
			//13. Write a C# Sharp program that checks whether one temperature is
			//less than 0 and another is greater than 100.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//bool res = CheckTemperatureIsLessThanZeroAndAnotherIsGreatetThan100(num1 , num2);
			//Console.WriteLine(res);

			#endregion
			#region Eaxmple14
			//14. Write a C# Sharp program to check two given integers
			//whether either of them is in the range 100..200 inclusive

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//bool res = CheckTwoNumberIsRange100And200(num1 , num2);
			//Console.WriteLine(res);

			#endregion
			#region Eaxmple15
			//15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
			//Return true if 1 or more of them are in the said range otherwise false.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());
			//int num3 = int.Parse(Console.ReadLine());

			//bool res = CheckThreeNumberIsRange20And50(num1, num2,num3);
			//Console.WriteLine(res);
			#endregion
			#region Eaxmple16
			//16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive.
			//Return true if 1 or other is in the range, otherwise false.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//bool reselt = CkeckNumberInRange20To50(num1, num2);
			//Console.WriteLine(reselt);

			#endregion
			#region Eaxmple17
			//17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string.
			//If it appears return a string without 'yt' otherwise return the original string.
			//string str = Console.ReadLine();

			//string res = RemoveYtAtIndex1(str);

			//Console.WriteLine(res);

			#endregion
			#region Eaxmple18
			//18. Write a C# Sharp program to check the largest number among three given integers.
			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());
			//int num3 = int.Parse(Console.ReadLine());

			//int reselt = CheckNumberLargest(num1 ,num2,num3);
			//Console.WriteLine(reselt);

			#endregion
			#region Eaxmple19
			//19. Write a C# Sharp program to check which number is closest to 100 among two given integers.
			//Return 0 if the two numbers are equal.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//int reselt = CheckNumberIsClosest100(num1, num2);
			//Console.WriteLine(reselt);

			#endregion
			#region Eaxmple20
			//20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive,
			//or they are both in the range 50..60 inclusive.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//bool reselt = CkeckNumberInRange40To50(num1, num2);
			//Console.WriteLine(reselt);

			#endregion
			#region Eaxmple21
			//21. Write a C# Sharp program to find the largest value from two positive integer
			//values in the range 20..30 inclusive. Return 0 if neither is in that range.

			//int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//int reselt = CheckNumberInRange20To30(num1, num2);
			//Console.WriteLine(reselt);
			#endregion
			#region Eaxmple22
			//22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
			// string str = Console.ReadLine();

			//bool res = CheckStringContainsBetween2To4ZCharacters(str);
			//Console.WriteLine(res);

			#endregion
			#region Eaxmple23
			//23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.

			//int num1 = int.Parse(Console.ReadLine());	
			//int num2 = int.Parse(Console.ReadLine());

			//bool res = HaveSameLastDigit(num1, num2);
			//Console.WriteLine(res);

			#endregion
			#region Eaxmple24

			//24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3,
			//then uppercase all the characters.

			//string str = Console.ReadLine();

			//string result = ConvertLast3ToUppercase(str);

			//Console.WriteLine(result);
			#endregion
			#region Eaxmple25
			//25.Write a C# Sharp program to create a string which is n
			//(non-negative integer) copies of a given string.

			//string str = Console.ReadLine();
			//int number = int.Parse(Console.ReadLine());
			//string res = CopiesOfGivenString(str, number);

			//Console.WriteLine(res);



			#endregion

			/* End The Part One Of Problem Solving In C# ( 1 - 25) */

			/* Part Two Of The Problem Solving In C# ( 62 - 74 ) */

			#region Example 12

			//12. Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.

			//Console.WriteLine("Input number of strings : ");
			//int number = int.Parse(Console.ReadLine());

			//Console.WriteLine($"Input {number} strings below :");
			//string[] inputString = new string[number];

			//for (int i = 0; i < number; i++)
			//{
			//	inputString[i] = Console.ReadLine();
			//}


			////  bubble sort
			//for (int i = 0; i < inputString.Length - 1; i++)
			//{
			//	for (int j = 0; j < inputString.Length - i - 1; j++)
			//	{
			//		if (string.Compare(inputString[j], inputString[j+1])>0)
			//		{
			//			// Swap string
			//			string temp = inputString[j];
			//			inputString[j] = inputString[j + 1];
			//			inputString[j + 1] = temp;
			//		}
			//	}
			//}

			//Console.WriteLine("\nAfter sorting, the array appears like:");
			//for (int i = 0; i < number; i++)
			//{
			//	Console.WriteLine(inputString[i]);
			//}

			#endregion
			#region Example 13

			//13. Write a program in C# Sharp to extract a
			//substring from a given string without using the library function.

			//Console.WriteLine("Input the string : ");

			//string inputString = Console.ReadLine();

			//Console.WriteLine("Input the position to start extraction : ");

			//int startExtraction = int.Parse(Console.ReadLine());

			//Console.WriteLine("Input the length of substring : ");

			//int lengthOfSubstring = int.Parse(Console.ReadLine());

			//string extractedSubstring = ExtractString(inputString, startExtraction, lengthOfSubstring);

			//Console.WriteLine("The substring retrieve from the string is :  " + extractedSubstring);

			#endregion
			#region Example 14

			//14. Write a C# Sharp program to check whether a given substring is present in the given string.

			//Console.Write("Input the string :");
			//string str = Console.ReadLine();
			//Console.Write("Input the substring to search :");
			//string search = Console.ReadLine();

			// CheckSubString(str, search);

			#endregion
			#region Example 15

			//15. Write a C# Sharp program to read a sentence
			//and replace lowercase characters with uppercase and vice-versa.

			//Console.Write("Input the string : ");
			//string str = Console.ReadLine();

			//string result = ReplaceLowercaseCharactersWithUppercase(str);

			//Console.Write("After conversion, the string is : " + result);


			#endregion
			#region Example 16

			//16. Write a program in C# Sharp to check the username and password.

			//string validUsername = "user";
			//string validPassword = "pass";

			//Console.WriteLine("Input a username: ");
			//string username = Console.ReadLine();

			//Console.WriteLine("Input a password: ");
			//string password = Console.ReadLine();

			//bool isAuthenticated = CheckCredentials(username, password, validUsername, validPassword);

			//if (isAuthenticated)
			//{
			//	Console.WriteLine("Password entered successfully!");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid username or password.");
			//}


			#endregion
			#region Example17

			// 17. Write a program in C# Sharp to search for the position of a substring within a string.

			//Console.Write("Input a String: ");
			//string inputString = Console.ReadLine();
			//Console.Write("Input a substring to be found in the string: ");
			//string searchString = Console.ReadLine();
			//SearchForThePositionOfASubString (inputString, searchString);

			#endregion
			#region Example 18

			//18. Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.

			//char inputChar = Console.ReadKey().KeyChar;
			//Console.WriteLine();
			//CheckWhetherACharacterIsAnAlphabet(inputChar);



			#endregion
			#region Example 19
			//19. Write a program in C# Sharp to find the number of times a substring appears in a given string.

			//Console.Write("Input a String: ");
			//string inputString = Console.ReadLine();
			//Console.Write("Input a substring to be found in the string: ");
			//string searchString = Console.ReadLine();

			//FindTheNumberItemsOfSubCString(inputString, searchString);
			#endregion
			#region Example 20

			//20. Write a program in C# Sharp to insert a substring before the first occurrence of a string.

			//Console.Write("Input a String: ");
			//string inputString = Console.ReadLine();
			//Console.Write("Input a substring to be found in the string: ");
			//string searchString = Console.ReadLine();
			//Console.WriteLine("Input the string to be inserted : ");
			//string insertString = Console.ReadLine();

			//SearchStringAndInsertString(inputString, searchString, insertString);

			#endregion
			#region Example 21

			//21. Write a C# Sharp program to compare (less than, greater than, equal to) two substrings.

			//Console.WriteLine("Enter the first string: ");
			//string str1 = Console.ReadLine();

			//Console.WriteLine("Enter the second string: ");
			//string str2 = Console.ReadLine();

			//Console.WriteLine("Enter the first substring to compare: ");
			//string substring1 = Console.ReadLine();

			//Console.WriteLine("Enter the second substring to compare: ");
			//string substring2 = Console.ReadLine();

			//int comparisonResult = CompareSubstrings(str1, substring1, str2, substring2);

			//if (comparisonResult < 0)
			//{
			//	Console.WriteLine("Substring '" + substring1 + "' in '" + str1 + "' is less than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else if (comparisonResult > 0)
			//{
			//	Console.WriteLine("Substring '" + substring1 + "' in '" + str1 + "' is greater than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else
			//{
			//	Console.WriteLine("Substring '" + substring1 + "' in '" + str1 + "' is equal to substring '" + substring2 + "' in '" + str2 + "'.");
			//}


			#endregion
			#region Example 22

			//22. Write a C# Sharp program to compare two substrings that only differ in case.
			//The first comparison ignores case and the second comparison considers case.

			//Console.WriteLine("Enter the first string: ");
			//string str1 = Console.ReadLine();

			//Console.WriteLine("Enter the second string: ");
			//string str2 = Console.ReadLine();

			//Console.WriteLine("Enter the first substring to compare: ");
			//string substring1 = Console.ReadLine();

			//Console.WriteLine("Enter the second substring to compare: ");
			//string substring2 = Console.ReadLine();

			//// Comparison ignoring case
			//int comparisonIgnoreCase = CompareSubstrings(str1, substring1, str2, substring2, ignoreCase: true);

			//if (comparisonIgnoreCase < 0)
			//{
			//	Console.WriteLine("Ignore case: Substring '" + substring1 + "' in '" + str1 + "' is less than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else if (comparisonIgnoreCase > 0)
			//{
			//	Console.WriteLine("Ignore case: Substring '" + substring1 + "' in '" + str1 + "' is greater than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else
			//{
			//	Console.WriteLine("Ignore case: Substring '" + substring1 + "' in '" + str1 + "' is equal to substring '" + substring2 + "' in '" + str2 + "'.");
			//}

			//// Honor case:

			//int HonorConsiderCase = CompareSubstrings(str1, substring1, str2, substring2, ignoreCase: false);

			//if (HonorConsiderCase < 0)
			//{
			//	Console.WriteLine("Consider case: Substring '" + substring1 + "' in '" + str1 + "' is less than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else if (HonorConsiderCase > 0)
			//{
			//	Console.WriteLine("Consider case: Substring '" + substring1 + "' in '" + str1 + "' is greater than substring '" + substring2 + "' in '" + str2 + "'.");
			//}
			//else
			//{
			//	Console.WriteLine("Consider case: Substring '" + substring1 + "' in '" + str1 + "' is equal to substring '" + substring2 + "' in '" + str2 + "'.");
			//}

			#endregion
			#region Example 23

			//23. Write a C# Sharp program to compare two substrings using different cultures and ignore the substring case.

			//Console.Write("str1 = ");
			//string str1 = Console.ReadLine();
			//Console.Write("str2 = ");
			//string str2 = Console.ReadLine();

			//Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
			//Console.WriteLine();

			//// Ignore case, Turkish culture
			//CompareSubstrings(str1, str2, new CultureInfo("tr-TR"));

			//Console.WriteLine();

			//// Ignore case, invariant culture
			//CompareSubstrings(str1, str2, CultureInfo.InvariantCulture);


			#endregion
			#region Example 24

			//

			// Create two Person objects
			//Person person1 = new Person { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };
			//Person person2 = new Person { FirstName = Console.ReadLine(), LastName = Console.ReadLine() };

			//// Create a list to store the persons
			//List<Person> persons = new List<Person> { person1, person2 };

			//// Sort the persons based on last name
			//persons.Sort((p1, p2) => string.Compare(p1.LastName, p2.LastName));

			//// Display the sorted list
			//Console.WriteLine("Sorted list based on last name:");
			//foreach (var person in persons)
			//{
			//	Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
			//}


			#endregion
			#region Example 25
			//25. Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.
			//Note: The strings "encyclopedia" and "encyclopedia" are considered equivalent in the en-US culture but not in the Sami(Northern Sweden) culture.

			string word1 = Console.ReadLine();
			string word2 = Console.ReadLine();

			Console.WriteLine("case = Case (CurrentCulture): {0}", string.Equals(word1, word2, StringComparison.CurrentCulture));
			Console.WriteLine("case = Case (CurrentCultureIgnoreCase): {0}", string.Equals(word1, word2, StringComparison.CurrentCultureIgnoreCase));
			Console.WriteLine("case = Case (InvariantCulture): {0}", string.Equals(word1, word2, StringComparison.InvariantCulture));
			Console.WriteLine("case = Case (InvariantCultureIgnoreCase): {0}", string.Equals(word1, word2, StringComparison.InvariantCultureIgnoreCase));
			Console.WriteLine("case = Case (Ordinal): {0}", string.Equals(word1, word2, StringComparison.Ordinal));
			Console.WriteLine("case = Case (OrdinalIgnoreCase): {0}", string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase));

			#endregion

			/* Part Three Of The Problem Solving In C# ( 62 - 74 ) */
		}
		class Person
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}
	}
}