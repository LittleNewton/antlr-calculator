using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Antlr4.Runtime.Tree;

namespace antlr_calculator
{
    class MyVisitor : CalculatorBaseVisitor<int>
    {
        // Define the dict
        Dictionary<string, int> memory = new Dictionary<string, int>();

        /* ID '=' expr NEWLINE */
        public override int VisitAssign(CalculatorParser.AssignContext context)
        {
            string id = context.ID().GetText(); // id is left-hand side of '='
            int value = Visit(context.expr());  // compute value of expression on right
            memory.Add(id, value);
            return value;
        }

        /* expr NEWLINE */
        public override int VisitPrintExpr(CalculatorParser.PrintExprContext context)
        {
            int value = Visit(context.expr());
            Console.WriteLine(value);
            return 0;
        }


        /* INT */
        public override int VisitInt(CalculatorParser.IntContext context)
        {
            int value = int.Parse(context.INT().GetText());
            return value;
        }

        /* ID */
        public override int VisitId(CalculatorParser.IdContext context)
        {
            string id = context.ID().GetText();
            if (memory.ContainsKey(id))
            {
                return memory[id];
            }

            return 0;
        }

        /* expr op=('*' | '/') expr */
        public override int VisitMulDiv(CalculatorParser.MulDivContext context)
        {
            int left = Visit(context.expr(0));
            int right = Visit(context.expr(1));
            if(context.op.Type == CalculatorParser.MUL)
            {
                return left * right;
            }
            return left / right;
        }

        /* expr op=('+' | '-') expr */
        public override int VisitAddSub(CalculatorParser.AddSubContext context)
        {
            int left = Visit(context.expr(0));
            int right = Visit(context.expr(1));
            if (context.op.Type == CalculatorParser.ADD)
            {
                return left + right;
            }
            return left - right;
        }

        public override int VisitParens(CalculatorParser.ParensContext context)
        {
            return Visit(context.expr());
        }
    }
}
