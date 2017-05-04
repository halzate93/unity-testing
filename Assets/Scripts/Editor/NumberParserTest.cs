using NUnit.Framework;

public class NumberParserTest 
{
	[TestCase (10, "X")]
	[TestCase (100, "C")]
	[TestCase (9, "IX")]
	[TestCase (1969, "MCMLXIX")]
	public void ParsesSingleDigitArabicNumber (int input, string result) 
	{
		NumberParser parser = new NumberParser ();
		string parsed = parser.DecimalToRoman (input);
		Assert.AreEqual (result, parsed);
	}
}
