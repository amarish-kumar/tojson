# ToJson()
Snippet for a static .ToJson() method in C#

I use it in my unit testing projects to see object hierarchies.
Use it in conjunction with xunit.net's 'ITestOuputHelper.WriteLine()` method like so:

	output.WriteLine(object.ToJson())