using antlr_calculator;
using Antlr4.Runtime;
using System;
using System.Numerics;

namespace antlr_calculator
{
    class MyCalculator
    {
        static void Main(string[] args)
        {
            string ab = @"
193
a = 5
b = 6
a+b*2
(1+2)*3
";
            var inputStream = new AntlrInputStream(ab);
            var lexer = new CalculatorLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new CalculatorParser(commonTokenStream);

            var parseTree = parser.prog();
            MyVisitor visitor = new MyVisitor();
            visitor.Visit(parseTree);
        }
    }
}
