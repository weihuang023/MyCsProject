using System;
using System.Text.RegularExpressions;
using System.IO;

namespace MyCsProject
{	
	// Updated GitHub Connection
	// delegate int NumberChanger(int n);
	// class Delegate { method addNum; method multNum; method getNum }
	// Create delegate instances
	// NumberChanger nc1 = new NumberChanger(AddNum);
	// NumberChanger nc2 = new NumberChanger(MultNum);
	class BinaryS{
	public void finds(int num) {
		int [] arr = new int[5]  {1,  98, 10, 97, 95};
		int first, last, middle, n=arr.Length, search;
		first = 0;
		last = n - 1;
		middle = (first + last) / 2;
		search = num;

		while (first <= last) {
			if (arr[middle] < search)
				first = middle + 1;
			else if (arr[middle] == search) {
					Console.WriteLine (search + " found at location "
					+ (middle + 1) + ".");
				break;
			} else
				last = middle - 1;
			middle = (first + last) / 2;
		}
		if (first > last)
				Console.WriteLine(search + " is not present in the list.\n");
		}
	}
	class RegEx
	{
		public void showMatch (string text, string expr)
		{
			Console.WriteLine ("The Expression: " + expr);
			MatchCollection mc = Regex.Matches (text, expr);
			foreach (Match m in mc) 
			{
				Console.WriteLine (m);
			}
		}

	}
	public interface ITranscations
	{	
		// interface members
		void showTransaction();
		double getAmount();
	}
	public class Transcation : ITranscations
	{
		private string tCode;
		private string date;
		private double amount;
		public Transcation()
		{
			tCode = " ";
			date = " ";
			amount = 0.0;
		}
		public Transcation(string c, string d, double a)
		{
			tCode = c;
			date = d;
			amount = a;
		}
		public double getAmount()
		{
			return amount;
		}
		public void showTransaction()
		{
			Console.WriteLine ("Transcation: {0}", tCode);
			Console.WriteLine ("Date: {0}", date);
			Console.WriteLine ("Amount: {0}", getAmount ());
		}
	}
	class Box 
	{
		private double length;
		private double breath;
		private double height;

		public double getVolume()
		{
			return length * breath * height;
		}

		public void setLength(double len)
		{
			length = len;
		}
		public void setBreath(double bre)
		{
			breath = bre;
		}
		public void setHeight(double hei)
		{
			height = hei;
		}

		// Overload + Operateor to add two Box Object
		public static Box operator+ (Box b, Box c)
		{
			Box box = new Box();
			box.length = b.length + c.length;
			box.breath = b.breath + c.breath;
			box.height = b.height + c.height;
			return box;
		}
		public override string ToString ()
		{
			return String.Format ("{0},{1},{2}", length,breath,height);
		}
	}
	class Rectangle 
	{	
		// MEMBER VariableS
		double wide;
		double length;

		// Actual Initialization Variable
		public void Details()
		{   
			try
			{
			//converts the data entered by the user to int data type
			Console.Write("Please Enter Wide: ");
			wide = Convert.ToDouble(Console.ReadLine());
			Console.Write("Please Enter Length: ");
			length = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception caught: {0}", e.Message);
			}
			finally 
			{
				Console.WriteLine("Wide {0}", wide);
				Console.WriteLine ("Length {0}", length);
			}
	
			// Read() Return string Value
			// ReadLine() Return int Value
			// ReadKey() Return char Value

			// Reference Type - Object, Dynamic, and String

			// Object - System.Object class
			// object obj;
			// obj = 100; // this is boxing
			// When an object type is converted to a value type, it is called unboxing

			// Dynamic 
			// dynamic d = 20;
			// similar to object types except that type checking 
			// for object type variables takes place at compile time 
			// whereas that for the dynamic type variables takes place at run time

			// String - System.String Class
			// Assign any string values to a variable
			// String str = "Tutorials Point";
			// @"Tutorials Point";

			// Pointer Type
			// Variables store the memory address of another type
			// type* identifier;
			// char* cptr;
			// int* iptr;

		}

		// Get Method and Calculate the Area Space
		public double GetArea()
		{	
			return wide * length;
		}

		// Display all the Information
		public void Displays()
		{	
			Console.WriteLine ("Length: {0}", length);
			Console.WriteLine ("Wide: {0}", wide);
			Console.WriteLine ("Area: {0}", GetArea());
		}

	}

	class NumberManipulator
	{   
		public int FindMax(int num1, int num2)
		{
			/* local variable declaration */
			int result;


			if (num1 > num2)
				result = num1;
			else
				result = num2;
			return result;
		}

		public int factorial(int num)
		{
			/* local variable declaration */
			int result;
			// Base Case: 
			if (num == 1) {
				return 1;
			} else {
			// Result 
				result = factorial (num - 1) * num;
				return result;
			}
		}

		// Passing Parameter by Value
		public void swap1(int x, int y)
		{
			int temp;

			temp = x; /* save the value of x */
			x = y;    /* put y into x */
			y = temp; /* put temp into y */
		}
		// Passing Parameter by Reference
		public void swap2(ref int x, ref int y)
		{
			int temp;

			temp = x; /* save the value of x */
			x = y;    /* put y into x */
			y = temp; /* put temp into y */
		}
		// Passing Parameter by Out
		public void getValue(out int x )
		{
			int temp = 5;
			x = temp;
		}
			
		public void getValues(out int x, out int y )
		{	
			
			//converts the data entered by the user to int data type
			Console.WriteLine("Enter the first value: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second value: ");
			y = Convert.ToInt32(Console.ReadLine());
		
		}
	}


	class Excecute 
	{
		static void Main (String[] args)
		{
			/* my first program in C# */
			Console.WriteLine("Hello World");
			BinaryS bs = new BinaryS ();
			int num = 20;
			bs.finds(num);
			Console.ReadKey ();
			// File is a collecation of data stored in a disk with a specific name and a directory path
			// When file is opened for reading or writing, it become a stream
			// Input stream is using for reading data from file - read operation
			// Output stream is using for writing into the file - write operation

			// filestream helps in reading from, writing to and closing files
			// FileStream <object_name> = new FileStream(<file_name>, <FileMode Enumerator>,
			// <FileAccess Enumerator>, <FileShare Enumerator>);
			// FileStream F = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

			FileStream F = new FileStream ("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			for (int i=1; i<=20; i++ )
			{
				F.WriteByte((byte)i);
			}
			F.Position = 0;
			for (int i=0; i<=20; i++)
			{
				Console.Write(F.ReadByte()+" ");
			}
			F.Close ();
			Console.ReadKey ();

			string str = "A thousand Splends Suns";
			string str1 = "make maze and manage to measure it";
			RegEx r = new RegEx ();
			Console.WriteLine ("Matching Words that start with 's' :");
			r.showMatch(str, @"\bS\S*");
			r.showMatch (str1,@"\bm\S*e\b");
			Console.ReadKey ();

			Transcation t1 = new Transcation ("001", "08/10/2012", 78900.00);
			Transcation t2 = new Transcation ("002", "09/10/2012", 98700.00);
			t1.showTransaction ();
			t2.showTransaction ();
			Console.ReadKey ();

			Box Box1 = new Box (); // Declare Box1 of type Box
			Box Box2 = new Box (); // Declare Box1 of type Box
			Box Box3 = new Box (); // Declare Box1 of type Box
			double volume = 0.0;	// Stroe the volume of box here
			// Box 1 Specification
			Box1.setBreath (6.0);
			Box1.setHeight (7.0);
			Box1.setLength (8.0);
			// Box 2 Specification
			Box2.setBreath (10.0);
			Box2.setHeight (11.0);
			Box2.setLength (12.0);
			// Volume 
			Console.WriteLine ("Box1: {0}", Box1.ToString());
			Console.WriteLine ("Box2: {0}", Box2.ToString());
			volume = Box1.getVolume ();
			Console.WriteLine ("Volume of Box1 : {0}", volume);
			volume = Box2.getVolume ();
			Console.WriteLine ("Volume of Box2 : {0}", volume);
			// + is operator 
			Box3 = Box1 + Box2;
			volume = Box3.getVolume ();
			Console.WriteLine ("Volume of Box3: {0}", volume);
			Console.ReadKey ();
			// Interface is defined as a syntactical contract that all the classes inheriting the interface should follow
			// Interface defines the "What" Part of the syntactical contract 
			// Deriving class defines the "How" part of the syntactical contract
			Rectangle r1 = new Rectangle ();
			r1.Details();
			r1.GetArea();
			r1.Displays();
			Console.ReadKey();
			Console.WriteLine ("Find the Max: ");
			/* local variable definition */
			int ret;
			int l = 100;
			int v = 20;
			NumberManipulator n = new NumberManipulator();
			// calling the FindMax method
			ret = n.FindMax(l, v);
			Console.WriteLine("Max value is : {0}", ret );
			Console.ReadLine();
			Console.WriteLine ("Factorial: ");
			//calling the factorial method
			Console.WriteLine("Factorial of 6 is : {0}", n.factorial(6));
			Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
			Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
			Console.ReadLine();
			Console.WriteLine ("Swap L and V");
			Console.WriteLine("Before swap, value of l : {0}", l);
			Console.WriteLine("Before swap, value of v : {0}", v);
			n.swap1 (l, v);
			Console.WriteLine("After swap, value of l : {0}", l);
			Console.WriteLine("After swap, value of v : {0}", v);
			Console.WriteLine("Parameter inside the method have no effect - Passing Parameters By Value");
			Console.ReadLine();
			Console.WriteLine ("Swap L and V");
			Console.WriteLine("Before swap, value of l : {0}", l);
			Console.WriteLine("Before swap, value of v : {0}", v);
			n.swap2 (ref l, ref v);
			Console.WriteLine("After swap, value of l : {0}", l);
			Console.WriteLine("After swap, value of v : {0}", v);
			Console.WriteLine("Parameter inside the method have effect - Passing Parameters By Reference");
			Console.ReadLine();
			Console.WriteLine ("Change Output 100 to 5");
			/* local variable definition */
			int o = 100;
			Console.WriteLine("Before method call, value of 100 : {0}", o);
			/* calling a function to get the value */
			n.getValue(out o);
			Console.WriteLine("After method call, value of 100 : {0}", o);
			Console.WriteLine("Parameter inside the method have effect- Passing Parameters By Output");
			Console.ReadLine();
			Console.WriteLine ("Change Output 100 and 20");
			n.getValues(out l, out v);
			Console.WriteLine("After method call, value of 100 : {0}", l);
			Console.WriteLine("After method call, value of 20 : {0}", v);
			Console.ReadLine();
			Console.WriteLine ("C# Size of Value Type");
			Console.WriteLine("Size of bool: {0}\t\t\t\t\t\t", sizeof(bool));
			Console.WriteLine("Size of byte: {0}\t\t\t\t\t\t", sizeof(byte));
			Console.WriteLine("Size of short: {0}\t\t\t\t\t", sizeof(short));
			Console.WriteLine("Size of char: {0}\t\t\t\t\t\t", sizeof(char));
			Console.WriteLine("Size of int: {0}\t\t\t\t\t\t\t", sizeof(int));
			Console.WriteLine("Size of float: {0}\t\t\t\t\t\t", sizeof(float));
			Console.WriteLine("Size of double: {0}\t\t\t\t\t\t", sizeof(double));
			Console.WriteLine("Size of long: {0}\t\t\t\t\t\t", sizeof(long));
			Console.WriteLine("Size of decimal: {0}\t\t\t\t\t", sizeof(decimal));
			Console.WriteLine("Size of sbyte: {0}\t\t\t\t\t\t", sizeof(sbyte));
			Console.WriteLine("Size of ushort: {0}\t\t\t\t\t\t", sizeof(ushort));
			Console.WriteLine("Size of uint: {0}\t\t\t\t\t\t\t", sizeof(uint));
			Console.WriteLine("Size of ulong: {0}\t\t\t\t\t\t", sizeof(ulong));
			Console.ReadKey();
			Console.WriteLine ("Explicit Type Conversion");
			double d = 5673.74; 
			// pre-defined functions
			int p;
			// cast double to int.
			p = (int)d;
			Console.WriteLine ("Double: "+d);
			Console.WriteLine("(int)Double: "+p);
			Console.ReadKey();
			Console.WriteLine ("Converts various Value types to String type");
			int e = 75;
			float f = 53.005f;
			double g = 2345.7652;
			bool h = true;
			Console.WriteLine("Int.ToString: "+e.ToString());
			Console.WriteLine("Float.ToString: "+f.ToString());
			Console.WriteLine("Double.ToString: "+g.ToString());
			Console.WriteLine("Boolean.ToString: "+h.ToString());
			Console.ReadKey();
			Console.WriteLine ("Different Variables: ");
			short a;
			int b ;
			double c;
			/* actual initialization */
			a = 10;
			b = 20;
			c = a + b;
			/* Index{0} Index{1} Index{2} */
			Console.WriteLine("a = {0}, b = {1}, c = {2}. ", a, b, c);
			Console.ReadLine();

			Console.WriteLine ("Variables Constant");
			const double pi = 3.14159;   
			// Constant Declaration 
			double radius;
			Console.WriteLine("Enter Radius: ");

			radius = Convert.ToDouble(Console.ReadLine());
			double areaCircle = pi * radius * radius;
			// Pi is Constant Value 
			Console.WriteLine("Radius: {0}, Area: {1}. ", radius, areaCircle);
			Console.ReadLine();
			Console.WriteLine("Logical Operation:");
			int x = 60;            /* 60 = 0011 1100 */ 
			int y = 13;            /* 13 = 0000 1101 */
			int z = 0; 
			z = x & y;             /* 12 = 0000 1100 */ 
			Console.WriteLine("Line 1 - Value of z is {0}", z );
			z = x | y;             /* 61 = 0011 1101 */
			Console.WriteLine("Line 2 - Value of z is {0}", z);
			z = x ^ y;             /* 49 = 0011 0001 */
			Console.WriteLine("Line 3 - Value of z is {0}", z);
			z = ~x;                /* -61 = 1100 0011 */
			Console.WriteLine("Line 4 - Value of z is {0}", z);
			z = x << 2;      	   /* 240 = 1111 0000 */
			Console.WriteLine("Line 5 - Value of z is {0}", z);
			z = x >> 2;     	   /* 15 = 0000 1111 */
			Console.WriteLine("Line 6 - Value of z is {0}", z);
			Console.ReadLine();
			Console.WriteLine ("Relational Operation: ");
			if (a == b)
			{
				Console.WriteLine("Line 1 - a is equal to b");
			}
			else 
			{
				Console.WriteLine("Line 1 - a is not equal to b");
			}

			if (a < b)
			{
				Console.WriteLine("Line 2 - a is less than b");
			}
			else
			{
				Console.WriteLine("Line 2 - a is not less than b");
			}

			if (a > b)
			{
				Console.WriteLine("Line 3 - a is greater than b");
			}
			else
			{
				Console.WriteLine("Line 3 - a is not greater than b");
			}
			/* Lets change value of a and b */
			a = 10000;
			b = 20;
			if (a <= b) 
			{ 
				Console.WriteLine("Line 4 - a is either less than or equal to  b");
			}
			else
			{
				Console.WriteLine ("Line 4 - a is greater than b");
			}
			if (b >= a)
			{
				Console.WriteLine("Line 5 - b is either greater than or equal to b");
			}
			else
			{
				Console.WriteLine ("Line 5 - b is less than a");
			}
			Console.ReadKey ();
			Console.WriteLine ("Case Statement: ");
			char grade = 'A';
			switch (grade)
			{
			case 'A':
				Console.WriteLine("Excellent!");
				break;
			case 'B':
			case 'C':
				Console.WriteLine("Well done");
				break;
			case 'D':
				Console.WriteLine("You passed");
				break;
			case 'F':
				Console.WriteLine("Better try again");
				break;
			default:
				Console.WriteLine("Invalid grade");
				break;
			}
			Console.WriteLine("Your grade is  {0}", grade);
			Console.ReadLine();
			Console.WriteLine ("Find the Prime: ");
			/* local variable definition */
			int w, u;
			for (w = 2; w < 100; w++)
			{
				for (u = 2; u <= (w / u); u++)
				if ((w % u) == 0) break; // if factor found, not prime
				if (u > (w / u))
					Console.WriteLine("{0} is prime", w);
			}
			Console.ReadLine();
			// Abstraction allows making relevant information visible
			// Encapsulation - Public, Private, Protected, Internal, Protected Internal 
			// Default access specifier of a class member - Private 
		}
	}
}