using System;
using System.IO;
using System.Net; 
using System.Text.RegularExpressions; 

//Purpose: Used for regular expressions and Pattern replacement of code
class Program
{
	public static void Main(string[] args)
	{
	
		string regexPattern = @"<!DOCTYPE html>";	// Pattern identified
		string replacement = @"TestSuccessful";		// Replacement of pattern 

		// Test File 
		string filePath = @"C:\Users\Khathutshelo Makatu\Downloads\temp\AddField.asp";	// Insert file here 
		string fileContent = File.ReadAllText(filePath);

		// Replace pattern with replace
		fileContent = Regex.Replace(fileContent, regexPattern, replacement);

		// Update and Save the file
		File.WriteAllText(filePath, fileContent);

		// Display update in console
		Console.WriteLine(fileContent); 
	}
}

