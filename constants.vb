Option Strict Off
Option Explicit On

Module constants

    Sub Main()
        'like microsoft example
        Const ANumber As Integer = 5I

        'Robotics Style Convention 
        ' Const ANOTHERNUMBER As Integer = 6I
        'const ANOTHERNUMBER% = 6%
        'Const ANOTHERNUMBER% = 6I
        ' "AS"integer statement does thee same as I and %. Use AS for assignments for now.
        'ALL CAPS IS A CLUE THAT ITS A CONSTANT AND NOT A VARIABLE  (in robotics convention)
        'include type character 
        'I indiscates constant

        Console.WriteLine(ANOTHERNUMBER%)
        '% indicates a constant as well



    End Sub

End Module
