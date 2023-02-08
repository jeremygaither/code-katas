using System;

namespace binary_chop;

class Program
{

  static int Chop(int searchValue, int[] values)
  {
    Array.Sort(values);

    int chopIndex = -1;
    int arrayLength = values.Length;
    Console.WriteLine("- start arrayLength: "+ arrayLength);

    int searchedLength = 1;

    for (int i = 0; i < arrayLength -1; i++)
    {
      Console.WriteLine($"- ${arrayLength}");

      if (arrayLength == 0)
      {
        Console.WriteLine("- Empty Array: " + chopIndex);

        break;
      }

      // TODO more stuff here

      searchedLength++;
    }

    return chopIndex;
  }

  static bool AssertEqual(int expectedValue, int actualValue)
  {
    bool testPassed = false;

    if (expectedValue == actualValue)
    {
      Console.WriteLine("Passed: " + expectedValue + " == " + actualValue );
      testPassed = true;
    } 
    else 
    { 
      Console.WriteLine("FAILED: " + expectedValue + " == " + actualValue );
      testPassed = false;
    }

    return testPassed;
  }

  public static void Main(string[] args)
  {
    Console.WriteLine("TEST 1: ");
    AssertEqual(-1, Chop(3, new int[] { }));

    Console.WriteLine("TEST 2: ");
    AssertEqual(-1, Chop(3, new int[] { 1 }));

    Console.WriteLine("TEST 3: ");
    AssertEqual(0, Chop(1, new int[] { 1 }));
  }
}
