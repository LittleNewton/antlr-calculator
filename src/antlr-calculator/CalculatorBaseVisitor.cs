//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICalculatorVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class CalculatorBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICalculatorVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] CalculatorParser.ProgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="CalculatorParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrintExpr([NotNull] CalculatorParser.PrintExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="CalculatorParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssign([NotNull] CalculatorParser.AssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="CalculatorParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlank([NotNull] CalculatorParser.BlankContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParens([NotNull] CalculatorParser.ParensContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMulDiv([NotNull] CalculatorParser.MulDivContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddSub([NotNull] CalculatorParser.AddSubContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitId([NotNull] CalculatorParser.IdContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInt([NotNull] CalculatorParser.IntContext context) { return VisitChildren(context); }
}
