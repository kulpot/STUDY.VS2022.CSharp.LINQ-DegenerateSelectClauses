﻿using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=_ToabhDQliE&list=PL90AF0EFFEF782D27&index=10
//

static class MainClass
{
    static IEnumerable<int> Where(
        this int[] ints, Func<int, bool> gauntlet)
    {
        Console.WriteLine("My Where()");
        foreach (int i in ints)
            if (gauntlet(i))
                yield return i;
    }
    static void Main()
    {
        int[] numbers = new[] { 2, 4, 9, 4, 13, 2 };
        var result1 =
            from n in numbers
            where n < 5
            select n;
        var result2 =
            numbers
                .Where(n => n < 5);
                //.Select(n => n);
        //var result3 = Enumerable.Select(Enumerable.Where(numbers, n => n < 5), n => n);

        foreach (int worthyInt in result1)
            Console.WriteLine(worthyInt);
        Console.WriteLine();
        foreach (int worthyInt in result2)
            Console.WriteLine(worthyInt);

    }
}