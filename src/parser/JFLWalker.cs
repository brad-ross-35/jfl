//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.2 ./src/Parser/Grammar/JFLWalker.g 2013-08-10 15:42:51

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;
using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace JFLCSharp
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5.0.2")]
[System.CLSCompliant(false)]
public partial class JFLWalker : Antlr.Runtime.Tree.TreeParser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "BLOCK", "CHAIN_OPERATOR", "COMPARATOR", "DIGIT", "ESCAPE_SEQ", "ESC_ID", "ESC_STRING", "EXPONENT", "EXPR", "FALSE", "FILTER", "HEX_DIGIT", "ID", "NULL", "NUMBER", "REGEX", "STRING", "TRUE", "UNICODE_ESC", "WS", "'!'", "'('", "')'", "'*'", "','", "'.'", "':'", "'?'", "'['", "']'", "'{'", "'}'"
	};
	public const int EOF=-1;
	public const int BLOCK=4;
	public const int CHAIN_OPERATOR=5;
	public const int COMPARATOR=6;
	public const int DIGIT=7;
	public const int ESCAPE_SEQ=8;
	public const int ESC_ID=9;
	public const int ESC_STRING=10;
	public const int EXPONENT=11;
	public const int EXPR=12;
	public const int FALSE=13;
	public const int FILTER=14;
	public const int HEX_DIGIT=15;
	public const int ID=16;
	public const int NULL=17;
	public const int NUMBER=18;
	public const int REGEX=19;
	public const int STRING=20;
	public const int TRUE=21;
	public const int UNICODE_ESC=22;
	public const int WS=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
	public const int T__27=27;
	public const int T__28=28;
	public const int T__29=29;
	public const int T__30=30;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int T__35=35;

	public JFLWalker(ITreeNodeStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public JFLWalker(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}

	public override string[] TokenNames { get { return JFLWalker.tokenNames; } }
	public override string GrammarFileName { get { return "./src/Parser/Grammar/JFLWalker.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_walk();
	partial void LeaveRule_walk();
	// $ANTLR start "walk"
	// ./src/Parser/Grammar/JFLWalker.g:11:8: public walk[JFLProperty jfl] : block[jfl] ;
	[GrammarRule("walk")]
	public void walk(JFLProperty jfl)
	{
		EnterRule_walk();
		EnterRule("walk", 1);
		TraceIn("walk", 1);
		try { DebugEnterRule(GrammarFileName, "walk");
		DebugLocation(11, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:12:2: ( block[jfl] )
			DebugEnterAlt(1);
			// ./src/Parser/Grammar/JFLWalker.g:12:4: block[jfl]
			{
			DebugLocation(12, 4);
			PushFollow(Follow._block_in_walk41);
			block(jfl);
			PopFollow();


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("walk", 1);
			LeaveRule("walk", 1);
			LeaveRule_walk();
		}
		DebugLocation(13, 1);
		} finally { DebugExitRule(GrammarFileName, "walk"); }
		return;

	}
	// $ANTLR end "walk"

	partial void EnterRule_block();
	partial void LeaveRule_block();
	// $ANTLR start "block"
	// ./src/Parser/Grammar/JFLWalker.g:15:1: block[JFLProperty currScope] : ^( BLOCK ( property[currScope] )* ) ;
	[GrammarRule("block")]
	private void block(JFLProperty currScope)
	{
		EnterRule_block();
		EnterRule("block", 2);
		TraceIn("block", 2);
		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(15, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:16:2: ( ^( BLOCK ( property[currScope] )* ) )
			DebugEnterAlt(1);
			// ./src/Parser/Grammar/JFLWalker.g:16:4: ^( BLOCK ( property[currScope] )* )
			{
			DebugLocation(16, 4);
			DebugLocation(16, 6);
			Match(input,BLOCK,Follow._BLOCK_in_block56); 

			if (input.LA(1) == TokenTypes.Down)
			{
				Match(input, TokenTypes.Down, null); 
				DebugLocation(16, 12);
				// ./src/Parser/Grammar/JFLWalker.g:16:12: ( property[currScope] )*
				try { DebugEnterSubRule(1);
				while (true)
				{
					int alt1=2;
					try { DebugEnterDecision(1, false);
					int LA1_1 = input.LA(1);

					if ((LA1_1==ESC_ID||LA1_1==ID||LA1_1==REGEX||LA1_1==27))
					{
						alt1 = 1;
					}


					} finally { DebugExitDecision(1); }
					switch ( alt1 )
					{
					case 1:
						DebugEnterAlt(1);
						// ./src/Parser/Grammar/JFLWalker.g:16:12: property[currScope]
						{
						DebugLocation(16, 12);
						PushFollow(Follow._property_in_block58);
						property(currScope);
						PopFollow();


						}
						break;

					default:
						goto loop1;
					}
				}

				loop1:
					;

				} finally { DebugExitSubRule(1); }


				Match(input, TokenTypes.Up, null); 
			}


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("block", 2);
			LeaveRule("block", 2);
			LeaveRule_block();
		}
		DebugLocation(17, 1);
		} finally { DebugExitRule(GrammarFileName, "block"); }
		return;

	}
	// $ANTLR end "block"

	partial void EnterRule_property();
	partial void LeaveRule_property();
	// $ANTLR start "property"
	// ./src/Parser/Grammar/JFLWalker.g:19:1: property[JFLProperty parentScope] : ^( propertyName (not= '!' )? ( filter[newProperty] )? ( block[newProperty] )? ) ;
	[GrammarRule("property")]
	private void property(JFLProperty parentScope)
	{
		EnterRule_property();
		EnterRule("property", 3);
		TraceIn("property", 3);
		CommonTree not = default(CommonTree);
		TreeRuleReturnScope<CommonTree> propertyName1 = default(TreeRuleReturnScope<CommonTree>);


			JFLProperty newProperty = new JFLProperty();

		try { DebugEnterRule(GrammarFileName, "property");
		DebugLocation(19, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:23:2: ( ^( propertyName (not= '!' )? ( filter[newProperty] )? ( block[newProperty] )? ) )
			DebugEnterAlt(1);
			// ./src/Parser/Grammar/JFLWalker.g:23:4: ^( propertyName (not= '!' )? ( filter[newProperty] )? ( block[newProperty] )? )
			{
			DebugLocation(23, 4);
			DebugLocation(23, 6);
			PushFollow(Follow._propertyName_in_property80);
			propertyName1=propertyName();
			PopFollow();


			if (input.LA(1) == TokenTypes.Down)
			{
				Match(input, TokenTypes.Down, null); 
				DebugLocation(23, 22);
				// ./src/Parser/Grammar/JFLWalker.g:23:22: (not= '!' )?
				int alt2=2;
				try { DebugEnterSubRule(2);
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if ((LA2_1==24))
				{
					alt2 = 1;
				}
				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:23:22: not= '!'
					{
					DebugLocation(23, 22);
					not=(CommonTree)Match(input,24,Follow._24_in_property84); 

					}
					break;

				}
				} finally { DebugExitSubRule(2); }

				DebugLocation(23, 28);
				// ./src/Parser/Grammar/JFLWalker.g:23:28: ( filter[newProperty] )?
				int alt3=2;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1==FILTER))
				{
					alt3 = 1;
				}
				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:23:28: filter[newProperty]
					{
					DebugLocation(23, 28);
					PushFollow(Follow._filter_in_property87);
					filter(newProperty);
					PopFollow();


					}
					break;

				}
				} finally { DebugExitSubRule(3); }

				DebugLocation(23, 49);
				// ./src/Parser/Grammar/JFLWalker.g:23:49: ( block[newProperty] )?
				int alt4=2;
				try { DebugEnterSubRule(4);
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1==BLOCK))
				{
					alt4 = 1;
				}
				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:23:49: block[newProperty]
					{
					DebugLocation(23, 49);
					PushFollow(Follow._block_in_property91);
					block(newProperty);
					PopFollow();


					}
					break;

				}
				} finally { DebugExitSubRule(4); }


				Match(input, TokenTypes.Up, null); 
			}

			DebugLocation(23, 70);

						if ((not!=null?not.Text:default(string)) == "!")
							newProperty.ToggleInclude();
						if ((propertyName1!=null?((JFLWalker.propertyName_return)propertyName1).isRegex:default(bool)))
							parentScope.AddRegexProperty((propertyName1!=null?((JFLWalker.propertyName_return)propertyName1).name:default(string)), newProperty);
						else
							parentScope.AddProperty((propertyName1!=null?((JFLWalker.propertyName_return)propertyName1).name:default(string)), newProperty);
					

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("property", 3);
			LeaveRule("property", 3);
			LeaveRule_property();
		}
		DebugLocation(31, 1);
		} finally { DebugExitRule(GrammarFileName, "property"); }
		return;

	}
	// $ANTLR end "property"

	private sealed partial class propertyName_return : TreeRuleReturnScope<CommonTree>
	{
		public string name;
		public bool isRegex;
		public propertyName_return(JFLWalker grammar) {OnCreated(grammar);}
		partial void OnCreated(JFLWalker grammar);
	}

	partial void EnterRule_propertyName();
	partial void LeaveRule_propertyName();
	// $ANTLR start "propertyName"
	// ./src/Parser/Grammar/JFLWalker.g:33:1: propertyName returns [string name, bool isRegex] : ( ID | ESC_ID | REGEX | '*' );
	[GrammarRule("propertyName")]
	private JFLWalker.propertyName_return propertyName()
	{
		EnterRule_propertyName();
		EnterRule("propertyName", 4);
		TraceIn("propertyName", 4);
		JFLWalker.propertyName_return retval = new JFLWalker.propertyName_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree ID2 = default(CommonTree);
		CommonTree ESC_ID3 = default(CommonTree);
		CommonTree REGEX4 = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "propertyName");
		DebugLocation(33, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:34:2: ( ID | ESC_ID | REGEX | '*' )
			int alt5=4;
			try { DebugEnterDecision(5, false);
			switch (input.LA(1))
			{
			case ID:
				{
				alt5 = 1;
				}
				break;
			case ESC_ID:
				{
				alt5 = 2;
				}
				break;
			case REGEX:
				{
				alt5 = 3;
				}
				break;
			case 27:
				{
				alt5 = 4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// ./src/Parser/Grammar/JFLWalker.g:34:4: ID
				{
				DebugLocation(34, 4);
				ID2=(CommonTree)Match(input,ID,Follow._ID_in_propertyName112); 
				DebugLocation(34, 7);

							retval.isRegex = false;
							retval.name =(ID2!=null?ID2.Text:default(string));
							

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// ./src/Parser/Grammar/JFLWalker.g:38:4: ESC_ID
				{
				DebugLocation(38, 4);
				ESC_ID3=(CommonTree)Match(input,ESC_ID,Follow._ESC_ID_in_propertyName119); 
				DebugLocation(38, 11);

							retval.isRegex = false;
							string stringText = (ESC_ID3!=null?ESC_ID3.Text:default(string));
							retval.name = stringText.Substring(1,stringText.Length - 2);
							

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// ./src/Parser/Grammar/JFLWalker.g:43:4: REGEX
				{
				DebugLocation(43, 4);
				REGEX4=(CommonTree)Match(input,REGEX,Follow._REGEX_in_propertyName126); 
				DebugLocation(43, 10);

							retval.isRegex = true;
							string regexText = (REGEX4!=null?REGEX4.Text:default(string));
							retval.name = regexText.Substring(1,regexText.Length - 2);
							

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// ./src/Parser/Grammar/JFLWalker.g:48:4: '*'
				{
				DebugLocation(48, 4);
				Match(input,27,Follow._27_in_propertyName133); 
				DebugLocation(48, 8);

							retval.isRegex = false;
							retval.name = "*";
							

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("propertyName", 4);
			LeaveRule("propertyName", 4);
			LeaveRule_propertyName();
		}
		DebugLocation(52, 1);
		} finally { DebugExitRule(GrammarFileName, "propertyName"); }
		return retval;

	}
	// $ANTLR end "propertyName"

	partial void EnterRule_filter();
	partial void LeaveRule_filter();
	// $ANTLR start "filter"
	// ./src/Parser/Grammar/JFLWalker.g:54:1: filter[JFLProperty currProperty] : ^( FILTER filterExpr ) ;
	[GrammarRule("filter")]
	private void filter(JFLProperty currProperty)
	{
		EnterRule_filter();
		EnterRule("filter", 5);
		TraceIn("filter", 5);
		FilterTreeNode filterExpr5 = default(FilterTreeNode);

		try { DebugEnterRule(GrammarFileName, "filter");
		DebugLocation(54, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:55:2: ( ^( FILTER filterExpr ) )
			DebugEnterAlt(1);
			// ./src/Parser/Grammar/JFLWalker.g:55:4: ^( FILTER filterExpr )
			{
			DebugLocation(55, 4);
			DebugLocation(55, 6);
			Match(input,FILTER,Follow._FILTER_in_filter149); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(55, 13);
			PushFollow(Follow._filterExpr_in_filter151);
			filterExpr5=filterExpr();
			PopFollow();


			Match(input, TokenTypes.Up, null); 

			DebugLocation(55, 25);

								currProperty.AddFilter(filterExpr5);
								

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("filter", 5);
			LeaveRule("filter", 5);
			LeaveRule_filter();
		}
		DebugLocation(58, 1);
		} finally { DebugExitRule(GrammarFileName, "filter"); }
		return;

	}
	// $ANTLR end "filter"

	partial void EnterRule_filterExpr();
	partial void LeaveRule_filterExpr();
	// $ANTLR start "filterExpr"
	// ./src/Parser/Grammar/JFLWalker.g:60:1: filterExpr returns [FilterTreeNode filterNode] : ( ^( comparator a= filterExpr b= filterExpr ) | ^( EXPR f= filterExpr (inverse= '!' )? ) | ^( EXPR propertyChain[propertySegments] (inverse= '?' )? (not= '!' )? ) | STRING | REGEX | NUMBER | TRUE | FALSE | NULL );
	[GrammarRule("filterExpr")]
	private FilterTreeNode filterExpr()
	{
		EnterRule_filterExpr();
		EnterRule("filterExpr", 6);
		TraceIn("filterExpr", 6);
		FilterTreeNode filterNode = default(FilterTreeNode);


		CommonTree inverse = default(CommonTree);
		CommonTree not = default(CommonTree);
		CommonTree STRING7 = default(CommonTree);
		CommonTree REGEX8 = default(CommonTree);
		CommonTree NUMBER9 = default(CommonTree);
		FilterTreeNode a = default(FilterTreeNode);
		FilterTreeNode b = default(FilterTreeNode);
		FilterTreeNode f = default(FilterTreeNode);
		string comparator6 = default(string);


			List<string> propertySegments = new List<string>();

		try { DebugEnterRule(GrammarFileName, "filterExpr");
		DebugLocation(60, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:64:2: ( ^( comparator a= filterExpr b= filterExpr ) | ^( EXPR f= filterExpr (inverse= '!' )? ) | ^( EXPR propertyChain[propertySegments] (inverse= '?' )? (not= '!' )? ) | STRING | REGEX | NUMBER | TRUE | FALSE | NULL )
			int alt9=9;
			try { DebugEnterDecision(9, false);
			switch (input.LA(1))
			{
			case CHAIN_OPERATOR:
			case COMPARATOR:
				{
				alt9 = 1;
				}
				break;
			case EXPR:
				{
				int LA9_2 = input.LA(2);

				if ((LA9_2==DOWN))
				{
					int LA9_3 = input.LA(3);

					if (((LA9_3>=CHAIN_OPERATOR && LA9_3<=COMPARATOR)||(LA9_3>=EXPR && LA9_3<=FALSE)||(LA9_3>=NULL && LA9_3<=TRUE)))
					{
						alt9 = 2;
					}
					else if ((LA9_3==ESC_ID||LA9_3==ID))
					{
						alt9 = 3;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 9, 9, input, 3);
						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 2, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case STRING:
				{
				alt9 = 4;
				}
				break;
			case REGEX:
				{
				alt9 = 5;
				}
				break;
			case NUMBER:
				{
				alt9 = 6;
				}
				break;
			case TRUE:
				{
				alt9 = 7;
				}
				break;
			case FALSE:
				{
				alt9 = 8;
				}
				break;
			case NULL:
				{
				alt9 = 9;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// ./src/Parser/Grammar/JFLWalker.g:64:4: ^( comparator a= filterExpr b= filterExpr )
				{
				DebugLocation(64, 4);
				DebugLocation(64, 6);
				PushFollow(Follow._comparator_in_filterExpr175);
				comparator6=comparator();
				PopFollow();


				Match(input, TokenTypes.Down, null); 
				DebugLocation(64, 18);
				PushFollow(Follow._filterExpr_in_filterExpr179);
				a=filterExpr();
				PopFollow();

				DebugLocation(64, 31);
				PushFollow(Follow._filterExpr_in_filterExpr183);
				b=filterExpr();
				PopFollow();


				Match(input, TokenTypes.Up, null); 

				DebugLocation(65, 4);

								Comparator newComparator;
								switch (comparator6) {
									case "=":
										newComparator = Comparator.Equals;
										break;
									case "!=":
										newComparator = Comparator.NotEquals;
										break;
									case ">":
										newComparator = Comparator.Greater;
										break;
									case "<":
										newComparator = Comparator.Less;
										break;
									case ">=":
										newComparator = Comparator.GreaterOrEqual;
										break;
									case "<=":
										newComparator = Comparator.LessOrEqual;
										break;
									case "&":
										newComparator = Comparator.And;
										break;
									case "|":
										newComparator = Comparator.Or;
										break;
									default:
										newComparator = Comparator.Equals;
										break;
								}
								filterNode = new BoolExpression(a, newComparator, b);
							

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// ./src/Parser/Grammar/JFLWalker.g:98:4: ^( EXPR f= filterExpr (inverse= '!' )? )
				{
				DebugLocation(98, 4);
				DebugLocation(98, 6);
				Match(input,EXPR,Follow._EXPR_in_filterExpr195); 

				Match(input, TokenTypes.Down, null); 
				DebugLocation(98, 12);
				PushFollow(Follow._filterExpr_in_filterExpr199);
				f=filterExpr();
				PopFollow();

				DebugLocation(98, 31);
				// ./src/Parser/Grammar/JFLWalker.g:98:31: (inverse= '!' )?
				int alt6=2;
				try { DebugEnterSubRule(6);
				try { DebugEnterDecision(6, false);
				int LA6_1 = input.LA(1);

				if ((LA6_1==24))
				{
					alt6 = 1;
				}
				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:98:31: inverse= '!'
					{
					DebugLocation(98, 31);
					inverse=(CommonTree)Match(input,24,Follow._24_in_filterExpr203); 

					}
					break;

				}
				} finally { DebugExitSubRule(6); }


				Match(input, TokenTypes.Up, null); 

				DebugLocation(99, 4);

								FilterTreeNode newNode = f;
								if ((inverse!=null?inverse.Text:default(string)) == "!")
									newNode.ToggleInversed();
								filterNode = newNode;
							

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// ./src/Parser/Grammar/JFLWalker.g:105:4: ^( EXPR propertyChain[propertySegments] (inverse= '?' )? (not= '!' )? )
				{
				DebugLocation(105, 4);
				DebugLocation(105, 6);
				Match(input,EXPR,Follow._EXPR_in_filterExpr216); 

				Match(input, TokenTypes.Down, null); 
				DebugLocation(105, 12);
				PushFollow(Follow._propertyChain_in_filterExpr219);
				propertyChain(propertySegments);
				PopFollow();

				DebugLocation(105, 51);
				// ./src/Parser/Grammar/JFLWalker.g:105:51: (inverse= '?' )?
				int alt7=2;
				try { DebugEnterSubRule(7);
				try { DebugEnterDecision(7, false);
				int LA7_1 = input.LA(1);

				if ((LA7_1==31))
				{
					alt7 = 1;
				}
				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:105:51: inverse= '?'
					{
					DebugLocation(105, 51);
					inverse=(CommonTree)Match(input,31,Follow._31_in_filterExpr224); 

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(105, 60);
				// ./src/Parser/Grammar/JFLWalker.g:105:60: (not= '!' )?
				int alt8=2;
				try { DebugEnterSubRule(8);
				try { DebugEnterDecision(8, false);
				int LA8_1 = input.LA(1);

				if ((LA8_1==24))
				{
					alt8 = 1;
				}
				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// ./src/Parser/Grammar/JFLWalker.g:105:60: not= '!'
					{
					DebugLocation(105, 60);
					not=(CommonTree)Match(input,24,Follow._24_in_filterExpr229); 

					}
					break;

				}
				} finally { DebugExitSubRule(8); }


				Match(input, TokenTypes.Up, null); 

				DebugLocation(106, 4);

								FilterTreeNode newProperty = new Property(propertySegments);
								if ((inverse!=null?inverse.Text:default(string)) == "?")
									filterNode = new BoolExpression(newProperty, Comparator.Equals, new Existence());
								else {
									if ((not!=null?not.Text:default(string)) == "!")
										newProperty.ToggleInversed();
									filterNode = newProperty;
								}
							

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// ./src/Parser/Grammar/JFLWalker.g:116:4: STRING
				{
				DebugLocation(116, 4);
				STRING7=(CommonTree)Match(input,STRING,Follow._STRING_in_filterExpr241); 
				DebugLocation(117, 4);

								string stringText = (STRING7!=null?STRING7.Text:default(string));
								stringText = stringText.Substring(1,stringText.Length - 2);
								filterNode = new Value(stringText);
							

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// ./src/Parser/Grammar/JFLWalker.g:122:4: REGEX
				{
				DebugLocation(122, 4);
				REGEX8=(CommonTree)Match(input,REGEX,Follow._REGEX_in_filterExpr251); 
				DebugLocation(123, 4);

								string regexText = (REGEX8!=null?REGEX8.Text:default(string));
								regexText = regexText.Substring(1,regexText.Length - 2);
								filterNode = new RegExp(regexText);
							

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// ./src/Parser/Grammar/JFLWalker.g:128:4: NUMBER
				{
				DebugLocation(128, 4);
				NUMBER9=(CommonTree)Match(input,NUMBER,Follow._NUMBER_in_filterExpr261); 
				DebugLocation(129, 4);

								filterNode = new Value(System.Double.Parse((NUMBER9!=null?NUMBER9.Text:default(string))));
							

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// ./src/Parser/Grammar/JFLWalker.g:132:4: TRUE
				{
				DebugLocation(132, 4);
				Match(input,TRUE,Follow._TRUE_in_filterExpr271); 
				DebugLocation(133, 4);

								filterNode = new Value(true);
							

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// ./src/Parser/Grammar/JFLWalker.g:136:4: FALSE
				{
				DebugLocation(136, 4);
				Match(input,FALSE,Follow._FALSE_in_filterExpr281); 
				DebugLocation(137, 4);

								filterNode = new Value(false);
							

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// ./src/Parser/Grammar/JFLWalker.g:140:4: NULL
				{
				DebugLocation(140, 4);
				Match(input,NULL,Follow._NULL_in_filterExpr291); 
				DebugLocation(141, 4);

								filterNode = new Value(null);
							

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("filterExpr", 6);
			LeaveRule("filterExpr", 6);
			LeaveRule_filterExpr();
		}
		DebugLocation(144, 1);
		} finally { DebugExitRule(GrammarFileName, "filterExpr"); }
		return filterNode;

	}
	// $ANTLR end "filterExpr"

	partial void EnterRule_propertyChain();
	partial void LeaveRule_propertyChain();
	// $ANTLR start "propertyChain"
	// ./src/Parser/Grammar/JFLWalker.g:146:1: propertyChain[List<string> propertySegments] : ( ^( ID propertyChain[propertySegments] ) | ^( ESC_ID propertyChain[propertySegments] ) );
	[GrammarRule("propertyChain")]
	private void propertyChain(List<string> propertySegments)
	{
		EnterRule_propertyChain();
		EnterRule("propertyChain", 7);
		TraceIn("propertyChain", 7);
		CommonTree ID10 = default(CommonTree);
		CommonTree ESC_ID11 = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "propertyChain");
		DebugLocation(146, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:147:2: ( ^( ID propertyChain[propertySegments] ) | ^( ESC_ID propertyChain[propertySegments] ) )
			int alt10=2;
			try { DebugEnterDecision(10, false);
			int LA10_1 = input.LA(1);

			if ((LA10_1==ID))
			{
				alt10 = 1;
			}
			else if ((LA10_1==ESC_ID))
			{
				alt10 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// ./src/Parser/Grammar/JFLWalker.g:147:4: ^( ID propertyChain[propertySegments] )
				{
				DebugLocation(147, 4);
				DebugLocation(147, 6);
				ID10=(CommonTree)Match(input,ID,Follow._ID_in_propertyChain310); 

				DebugLocation(148, 3);
				 propertySegments.Add((ID10!=null?ID10.Text:default(string))); 

				Match(input, TokenTypes.Down, null); 
				DebugLocation(149, 3);
				PushFollow(Follow._propertyChain_in_propertyChain318);
				propertyChain(propertySegments);
				PopFollow();


				Match(input, TokenTypes.Up, null); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// ./src/Parser/Grammar/JFLWalker.g:150:4: ^( ESC_ID propertyChain[propertySegments] )
				{
				DebugLocation(150, 4);
				DebugLocation(150, 6);
				ESC_ID11=(CommonTree)Match(input,ESC_ID,Follow._ESC_ID_in_propertyChain326); 

				DebugLocation(151, 3);
				 propertySegments.Add((ESC_ID11!=null?ESC_ID11.Text:default(string))); 

				Match(input, TokenTypes.Down, null); 
				DebugLocation(152, 3);
				PushFollow(Follow._propertyChain_in_propertyChain334);
				propertyChain(propertySegments);
				PopFollow();


				Match(input, TokenTypes.Up, null); 


				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("propertyChain", 7);
			LeaveRule("propertyChain", 7);
			LeaveRule_propertyChain();
		}
		DebugLocation(153, 1);
		} finally { DebugExitRule(GrammarFileName, "propertyChain"); }
		return;

	}
	// $ANTLR end "propertyChain"

	partial void EnterRule_comparator();
	partial void LeaveRule_comparator();
	// $ANTLR start "comparator"
	// ./src/Parser/Grammar/JFLWalker.g:155:1: comparator returns [string returnValue] : ( CHAIN_OPERATOR | COMPARATOR );
	[GrammarRule("comparator")]
	private string comparator()
	{
		EnterRule_comparator();
		EnterRule("comparator", 8);
		TraceIn("comparator", 8);
		string returnValue = default(string);


		CommonTree CHAIN_OPERATOR12 = default(CommonTree);
		CommonTree COMPARATOR13 = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "comparator");
		DebugLocation(155, 1);
		try
		{
			// ./src/Parser/Grammar/JFLWalker.g:156:2: ( CHAIN_OPERATOR | COMPARATOR )
			int alt11=2;
			try { DebugEnterDecision(11, false);
			int LA11_1 = input.LA(1);

			if ((LA11_1==CHAIN_OPERATOR))
			{
				alt11 = 1;
			}
			else if ((LA11_1==COMPARATOR))
			{
				alt11 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// ./src/Parser/Grammar/JFLWalker.g:156:4: CHAIN_OPERATOR
				{
				DebugLocation(156, 4);
				CHAIN_OPERATOR12=(CommonTree)Match(input,CHAIN_OPERATOR,Follow._CHAIN_OPERATOR_in_comparator352); 
				DebugLocation(156, 19);
				 returnValue = (CHAIN_OPERATOR12!=null?CHAIN_OPERATOR12.Text:default(string)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// ./src/Parser/Grammar/JFLWalker.g:157:4: COMPARATOR
				{
				DebugLocation(157, 4);
				COMPARATOR13=(CommonTree)Match(input,COMPARATOR,Follow._COMPARATOR_in_comparator359); 
				DebugLocation(157, 15);
				 returnValue = (COMPARATOR13!=null?COMPARATOR13.Text:default(string)); 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("comparator", 8);
			LeaveRule("comparator", 8);
			LeaveRule_comparator();
		}
		DebugLocation(158, 1);
		} finally { DebugExitRule(GrammarFileName, "comparator"); }
		return returnValue;

	}
	// $ANTLR end "comparator"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _block_in_walk41 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BLOCK_in_block56 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _property_in_block58 = new BitSet(new ulong[]{0x8090208UL});
		public static readonly BitSet _propertyName_in_property80 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _24_in_property84 = new BitSet(new ulong[]{0x4018UL});
		public static readonly BitSet _filter_in_property87 = new BitSet(new ulong[]{0x18UL});
		public static readonly BitSet _block_in_property91 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _ID_in_propertyName112 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ESC_ID_in_propertyName119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REGEX_in_propertyName126 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _27_in_propertyName133 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FILTER_in_filter149 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _filterExpr_in_filter151 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _comparator_in_filterExpr175 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _filterExpr_in_filterExpr179 = new BitSet(new ulong[]{0x3E3060UL});
		public static readonly BitSet _filterExpr_in_filterExpr183 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _EXPR_in_filterExpr195 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _filterExpr_in_filterExpr199 = new BitSet(new ulong[]{0x1000008UL});
		public static readonly BitSet _24_in_filterExpr203 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _EXPR_in_filterExpr216 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _propertyChain_in_filterExpr219 = new BitSet(new ulong[]{0x81000008UL});
		public static readonly BitSet _31_in_filterExpr224 = new BitSet(new ulong[]{0x1000008UL});
		public static readonly BitSet _24_in_filterExpr229 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _STRING_in_filterExpr241 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REGEX_in_filterExpr251 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_filterExpr261 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_filterExpr271 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_filterExpr281 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NULL_in_filterExpr291 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_propertyChain310 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _propertyChain_in_propertyChain318 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _ESC_ID_in_propertyChain326 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _propertyChain_in_propertyChain334 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _CHAIN_OPERATOR_in_comparator352 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _COMPARATOR_in_comparator359 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

} // namespace JFLCSharp
