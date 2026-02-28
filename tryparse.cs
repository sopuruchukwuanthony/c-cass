// string input = "123";
// bool success = int.TryParse(input, out int result);
// Console.WriteLine(success); // Output: True
// Console.WriteLine(result);  // Output: 123
// Original string 
		String s = "   GeeksForGeeks "; 

		// String before removing whitespaces
		Console.WriteLine($"Original string: '{s}'"); 

		// Applying Trim() method
		string res = s.Trim();
        
		// New string after removing whitespaces
		Console.WriteLine($"After Trim() method: '{res}'");