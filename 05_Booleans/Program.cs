﻿    bool isCool = false;
    isCool = true;

    bool isTrue = !false;
    bool isFalse = !true;

    bool trueAndExample = true && true;
    bool falseAndExample = true && false;

    bool trueOrExample = true || false;
    bool falseOrExample = false || false;

    bool trueExclusiveOr = true ^ false;
    bool falseExclusiveOr = true ^ true;

    Console.WriteLine($"Not false = {isTrue}");
    Console.WriteLine($"False AND TRUE = {falseAndExample}");
    Console.WriteLine($"True or True = {trueOrExample}");
    

    bool isGreaterThan = 10 > 10;
    bool isGreaterThanOrEqualTo = 10 >= 10;
    Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 {isGreaterThanOrEqualTo}");

    bool isLessThan = 5 < 5;
    bool isLessThanOrEqualTo = 5 <= 5;
    Console.WriteLine($"5 < 5 is {isLessThan}, Wow 5 <= 5 {isLessThanOrEqualTo}");


    bool equality = 17 == 9;
    bool inequality = 17 != 9

    Console.WriteLine($"17 is == 9 and 17 != 9 are {equality}, and {inequality}");