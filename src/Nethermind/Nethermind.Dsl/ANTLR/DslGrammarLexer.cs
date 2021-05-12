//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DslGrammar.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class DslGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WORD=1, DIGIT=2, ADDRESS=3, WS=4, BOOLEAN_OPERATOR=5, ARITHMETIC_SYMBOL=6, 
		CONDITION_VALUE=7, SOURCE=8, WATCH=9, WHERE=10, PUBLISH=11, AND=12, OR=13, 
		CONTAINS=14, PUBLISH_VALUE=15, WEBSOCKETS=16, LOG_PUBLISHER=17;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WORD", "DIGIT", "ADDRESS", "WS", "BOOLEAN_OPERATOR", "ARITHMETIC_SYMBOL", 
		"CONDITION_VALUE", "SOURCE", "WATCH", "WHERE", "PUBLISH", "AND", "OR", 
		"CONTAINS", "PUBLISH_VALUE", "WEBSOCKETS", "LOG_PUBLISHER"
	};


	public DslGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DslGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'SOURCE'", "'WATCH'", 
		"'WHERE'", "'PUBLISH'", "'AND'", "'OR'", "'CONTAINS'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WORD", "DIGIT", "ADDRESS", "WS", "BOOLEAN_OPERATOR", "ARITHMETIC_SYMBOL", 
		"CONDITION_VALUE", "SOURCE", "WATCH", "WHERE", "PUBLISH", "AND", "OR", 
		"CONTAINS", "PUBLISH_VALUE", "WEBSOCKETS", "LOG_PUBLISHER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DslGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DslGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x13', '\xC8', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x3', '\x2', '\x6', 
		'\x2', '\'', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '(', '\x3', '\x3', 
		'\x6', '\x3', ',', '\n', '\x3', '\r', '\x3', '\xE', '\x3', '-', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\x34', 
		'\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x37', '\v', '\x4', '\x3', '\x5', 
		'\x6', '\x5', ':', '\n', '\x5', '\r', '\x5', '\xE', '\x5', ';', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x42', 
		'\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 
		'M', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'R', 
		'\n', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x5', '\x10', '\x81', '\n', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x5', '\x11', '\xA1', '\n', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x5', '\x12', 
		'\xC7', '\n', '\x12', '\x2', '\x2', '\x13', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '\x3', 
		'\x2', '\a', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x3', '\x2', '\x32', 
		';', '\x5', '\x2', '\x32', ';', '\x43', 'H', '\x63', 'h', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', '\x2', '>', '>', '@', '@', 
		'\x2', '\xD7', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '&', '\x3', '\x2', '\x2', '\x2', '\x5', '+', '\x3', '\x2', '\x2', 
		'\x2', '\a', '/', '\x3', '\x2', '\x2', '\x2', '\t', '\x39', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x41', '\x3', '\x2', '\x2', '\x2', '\r', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'Q', '\x3', '\x2', '\x2', '\x2', '\x11', 'S', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 'Z', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'`', '\x3', '\x2', '\x2', '\x2', '\x17', '\x66', '\x3', '\x2', '\x2', 
		'\x2', '\x19', 'n', '\x3', '\x2', '\x2', '\x2', '\x1B', 'r', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', 'u', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x80', 
		'\x3', '\x2', '\x2', '\x2', '!', '\xA0', '\x3', '\x2', '\x2', '\x2', '#', 
		'\xC6', '\x3', '\x2', '\x2', '\x2', '%', '\'', '\t', '\x2', '\x2', '\x2', 
		'&', '%', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\x3', '\x2', '\x2', 
		'\x2', '(', '&', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', 
		'\x2', ')', '\x4', '\x3', '\x2', '\x2', '\x2', '*', ',', '\t', '\x3', 
		'\x2', '\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', 
		'\x2', '\x2', '-', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', '\x2', 
		'\x2', '\x2', '.', '\x6', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', 
		'\x32', '\x2', '\x2', '\x30', '\x31', '\a', 'z', '\x2', '\x2', '\x31', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x32', '\x34', '\t', '\x4', '\x2', 
		'\x2', '\x33', '\x32', '\x3', '\x2', '\x2', '\x2', '\x34', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x33', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x36', '\b', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x35', '\x3', '\x2', '\x2', '\x2', '\x38', ':', '\t', 
		'\x5', '\x2', '\x2', '\x39', '\x38', '\x3', '\x2', '\x2', '\x2', ':', 
		';', '\x3', '\x2', '\x2', '\x2', ';', '\x39', '\x3', '\x2', '\x2', '\x2', 
		';', '<', '\x3', '\x2', '\x2', '\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\b', '\x5', '\x2', '\x2', '>', '\n', '\x3', '\x2', '\x2', '\x2', 
		'?', '\x42', '\x5', '\r', '\a', '\x2', '@', '\x42', '\x5', '\x1D', '\xF', 
		'\x2', '\x41', '?', '\x3', '\x2', '\x2', '\x2', '\x41', '@', '\x3', '\x2', 
		'\x2', '\x2', '\x42', '\f', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', 
		'\a', '?', '\x2', '\x2', '\x44', 'M', '\a', '?', '\x2', '\x2', '\x45', 
		'\x46', '\a', '#', '\x2', '\x2', '\x46', 'M', '\a', '?', '\x2', '\x2', 
		'G', 'M', '\t', '\x6', '\x2', '\x2', 'H', 'I', '\a', '>', '\x2', '\x2', 
		'I', 'M', '\a', '?', '\x2', '\x2', 'J', 'K', '\a', '@', '\x2', '\x2', 
		'K', 'M', '\a', '?', '\x2', '\x2', 'L', '\x43', '\x3', '\x2', '\x2', '\x2', 
		'L', '\x45', '\x3', '\x2', '\x2', '\x2', 'L', 'G', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'H', '\x3', '\x2', '\x2', '\x2', 'L', 'J', '\x3', '\x2', '\x2', 
		'\x2', 'M', '\xE', '\x3', '\x2', '\x2', '\x2', 'N', 'R', '\x5', '\x3', 
		'\x2', '\x2', 'O', 'R', '\x5', '\x5', '\x3', '\x2', 'P', 'R', '\x5', '\a', 
		'\x4', '\x2', 'Q', 'N', '\x3', '\x2', '\x2', '\x2', 'Q', 'O', '\x3', '\x2', 
		'\x2', '\x2', 'Q', 'P', '\x3', '\x2', '\x2', '\x2', 'R', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'S', 'T', '\a', 'U', '\x2', '\x2', 'T', 'U', '\a', 
		'Q', '\x2', '\x2', 'U', 'V', '\a', 'W', '\x2', '\x2', 'V', 'W', '\a', 
		'T', '\x2', '\x2', 'W', 'X', '\a', '\x45', '\x2', '\x2', 'X', 'Y', '\a', 
		'G', '\x2', '\x2', 'Y', '\x12', '\x3', '\x2', '\x2', '\x2', 'Z', '[', 
		'\a', 'Y', '\x2', '\x2', '[', '\\', '\a', '\x43', '\x2', '\x2', '\\', 
		']', '\a', 'V', '\x2', '\x2', ']', '^', '\a', '\x45', '\x2', '\x2', '^', 
		'_', '\a', 'J', '\x2', '\x2', '_', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'`', '\x61', '\a', 'Y', '\x2', '\x2', '\x61', '\x62', '\a', 'J', '\x2', 
		'\x2', '\x62', '\x63', '\a', 'G', '\x2', '\x2', '\x63', '\x64', '\a', 
		'T', '\x2', '\x2', '\x64', '\x65', '\a', 'G', '\x2', '\x2', '\x65', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', 'R', '\x2', '\x2', 'g', 
		'h', '\a', 'W', '\x2', '\x2', 'h', 'i', '\a', '\x44', '\x2', '\x2', 'i', 
		'j', '\a', 'N', '\x2', '\x2', 'j', 'k', '\a', 'K', '\x2', '\x2', 'k', 
		'l', '\a', 'U', '\x2', '\x2', 'l', 'm', '\a', 'J', '\x2', '\x2', 'm', 
		'\x18', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x43', '\x2', '\x2', 
		'o', 'p', '\a', 'P', '\x2', '\x2', 'p', 'q', '\a', '\x46', '\x2', '\x2', 
		'q', '\x1A', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', 'Q', '\x2', '\x2', 
		's', 't', '\a', 'T', '\x2', '\x2', 't', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'u', 'v', '\a', '\x45', '\x2', '\x2', 'v', 'w', '\a', 'Q', '\x2', '\x2', 
		'w', 'x', '\a', 'P', '\x2', '\x2', 'x', 'y', '\a', 'V', '\x2', '\x2', 
		'y', 'z', '\a', '\x43', '\x2', '\x2', 'z', '{', '\a', 'K', '\x2', '\x2', 
		'{', '|', '\a', 'P', '\x2', '\x2', '|', '}', '\a', 'U', '\x2', '\x2', 
		'}', '\x1E', '\x3', '\x2', '\x2', '\x2', '~', '\x81', '\x5', '!', '\x11', 
		'\x2', '\x7F', '\x81', '\x5', '#', '\x12', '\x2', '\x80', '~', '\x3', 
		'\x2', '\x2', '\x2', '\x80', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x81', 
		' ', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', 'Y', '\x2', '\x2', 
		'\x83', '\x84', '\a', 'g', '\x2', '\x2', '\x84', '\x85', '\a', '\x64', 
		'\x2', '\x2', '\x85', '\x86', '\a', 'U', '\x2', '\x2', '\x86', '\x87', 
		'\a', 'q', '\x2', '\x2', '\x87', '\x88', '\a', '\x65', '\x2', '\x2', '\x88', 
		'\x89', '\a', 'm', '\x2', '\x2', '\x89', '\x8A', '\a', 'g', '\x2', '\x2', 
		'\x8A', '\x8B', '\a', 'v', '\x2', '\x2', '\x8B', '\xA1', '\a', 'u', '\x2', 
		'\x2', '\x8C', '\x8D', '\a', 'y', '\x2', '\x2', '\x8D', '\x8E', '\a', 
		'g', '\x2', '\x2', '\x8E', '\x8F', '\a', '\x64', '\x2', '\x2', '\x8F', 
		'\x90', '\a', 'U', '\x2', '\x2', '\x90', '\x91', '\a', 'q', '\x2', '\x2', 
		'\x91', '\x92', '\a', '\x65', '\x2', '\x2', '\x92', '\x93', '\a', 'm', 
		'\x2', '\x2', '\x93', '\x94', '\a', 'g', '\x2', '\x2', '\x94', '\x95', 
		'\a', 'v', '\x2', '\x2', '\x95', '\xA1', '\a', 'u', '\x2', '\x2', '\x96', 
		'\x97', '\a', 'y', '\x2', '\x2', '\x97', '\x98', '\a', 'g', '\x2', '\x2', 
		'\x98', '\x99', '\a', '\x64', '\x2', '\x2', '\x99', '\x9A', '\a', 'u', 
		'\x2', '\x2', '\x9A', '\x9B', '\a', 'q', '\x2', '\x2', '\x9B', '\x9C', 
		'\a', '\x65', '\x2', '\x2', '\x9C', '\x9D', '\a', 'm', '\x2', '\x2', '\x9D', 
		'\x9E', '\a', 'g', '\x2', '\x2', '\x9E', '\x9F', '\a', 'v', '\x2', '\x2', 
		'\x9F', '\xA1', '\a', 'u', '\x2', '\x2', '\xA0', '\x82', '\x3', '\x2', 
		'\x2', '\x2', '\xA0', '\x8C', '\x3', '\x2', '\x2', '\x2', '\xA0', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '\xA1', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\xA2', '\xA3', '\a', 'N', '\x2', '\x2', '\xA3', '\xA4', '\a', 'q', '\x2', 
		'\x2', '\xA4', '\xA5', '\a', 'i', '\x2', '\x2', '\xA5', '\xA6', '\a', 
		'R', '\x2', '\x2', '\xA6', '\xA7', '\a', 'w', '\x2', '\x2', '\xA7', '\xA8', 
		'\a', '\x64', '\x2', '\x2', '\xA8', '\xA9', '\a', 'n', '\x2', '\x2', '\xA9', 
		'\xAA', '\a', 'k', '\x2', '\x2', '\xAA', '\xAB', '\a', 'u', '\x2', '\x2', 
		'\xAB', '\xAC', '\a', 'j', '\x2', '\x2', '\xAC', '\xAD', '\a', 'g', '\x2', 
		'\x2', '\xAD', '\xC7', '\a', 't', '\x2', '\x2', '\xAE', '\xAF', '\a', 
		'n', '\x2', '\x2', '\xAF', '\xB0', '\a', 'q', '\x2', '\x2', '\xB0', '\xB1', 
		'\a', 'i', '\x2', '\x2', '\xB1', '\xB2', '\a', 'R', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', 'w', '\x2', '\x2', '\xB3', '\xB4', '\a', '\x64', '\x2', 
		'\x2', '\xB4', '\xB5', '\a', 'n', '\x2', '\x2', '\xB5', '\xB6', '\a', 
		'k', '\x2', '\x2', '\xB6', '\xB7', '\a', 'u', '\x2', '\x2', '\xB7', '\xB8', 
		'\a', 'j', '\x2', '\x2', '\xB8', '\xB9', '\a', 'g', '\x2', '\x2', '\xB9', 
		'\xC7', '\a', 't', '\x2', '\x2', '\xBA', '\xBB', '\a', 'n', '\x2', '\x2', 
		'\xBB', '\xBC', '\a', 'q', '\x2', '\x2', '\xBC', '\xBD', '\a', 'i', '\x2', 
		'\x2', '\xBD', '\xBE', '\a', 'r', '\x2', '\x2', '\xBE', '\xBF', '\a', 
		'w', '\x2', '\x2', '\xBF', '\xC0', '\a', '\x64', '\x2', '\x2', '\xC0', 
		'\xC1', '\a', 'n', '\x2', '\x2', '\xC1', '\xC2', '\a', 'k', '\x2', '\x2', 
		'\xC2', '\xC3', '\a', 'u', '\x2', '\x2', '\xC3', '\xC4', '\a', 'j', '\x2', 
		'\x2', '\xC4', '\xC5', '\a', 'g', '\x2', '\x2', '\xC5', '\xC7', '\a', 
		't', '\x2', '\x2', '\xC6', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xC6', 
		'\xAE', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xBA', '\x3', '\x2', '\x2', 
		'\x2', '\xC7', '$', '\x3', '\x2', '\x2', '\x2', '\r', '\x2', '(', '-', 
		'\x35', ';', '\x41', 'L', 'Q', '\x80', '\xA0', '\xC6', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}