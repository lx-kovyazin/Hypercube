using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypercube.Control
{
    public partial class CommandComponent : UserControl
    {
        private readonly MDXLexer mdxlexer;
        private int lastCaretPos = 0;
        private int maxLineNumberCharLength = 6;

        public CommandComponent()
        {
            InitializeComponent();
            mdxlexer = new MDXLexer("Dimension set member index END property from SELECT NON EMPTY COLUMNS FROM WHERE ROWS AXIS ON PAGES CHAPTERS SECTIONS PROPERTIES AFTER BEFORE ALL or AND NOT IN first AVERAGE FOR Level CREATE DELETE WHEN THEN Abs Aggregate Ancestor Attribute Avg BottomCount BottomPercent BottomSum CASE Children ClosingPeriod CoalesceEmpty Concat Contains Count Cousin CrossJoin CurrentMember CurrentTuple DateDiff DatePart DateRoll DateToMember DefaultMember Descendants Distinct DrilldownByLayer DrilldownMember DrillupByLayer DrillupMember Except Exp Extract Factorial FILTER FirstChild FirstSibling FormatDate GetFirstDate GetLastDate Generate Generations Generations Head Hierarchize IIF InStr Int Intersect IS IsAccType IsAncestor IsChild IsEmpty IsGeneration IsLeaf IsLevel IsSibling IsUda IsValid Item Item Lag LastChild LastPeriods LastSibling Lead Left Len Leaves Levels Levels Ln Log Log10 Lower LTrim Max Median MemberRange Members Min Mod NextMember NonEmptyCount NTile Ordinal ParallelPeriod Parent Percentile PeriodsToDate Power PrevMember Rank Remainder Right Round RTrim Siblings Stddev Stddevp StrToMbr StrToNum Subset Substring Sum Tail Todate TodateEx Today TopCount TopPercent TopSum Truncate TupleRange Uda Union Upper WithAttr Generation xTD IS ANY");
            FormatCodeBox();
        }

        private static bool IsBrace(char c) => "()[]{}".Contains(c);

        private void FormatCodeBox()
        {
            scintilla.Margins[0].Width = 16;
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();

            scintilla.Styles[MDXLexer.StyleDefault].ForeColor = Color.Black;
            scintilla.Styles[MDXLexer.StyleKeyword].ForeColor = Color.Blue;
            scintilla.Styles[MDXLexer.StyleIdentifier].ForeColor = Color.Teal;
            scintilla.Styles[MDXLexer.StyleNumber].ForeColor = Color.Purple;
            scintilla.Styles[MDXLexer.StyleString].ForeColor = Color.Red;

            scintilla.Lexer = Lexer.Container;
        }

        private void Scintilla_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            var startPos = scintilla.GetEndStyled();
            var endPos = e.Position;

            mdxlexer.Style(scintilla, startPos, endPos);
        }

        private void Scintilla_TextChanged(object sender, EventArgs e)
        {
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void Scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            // Has the caret changed position?
            var caretPos = scintilla.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace((char)scintilla.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace((char)scintilla.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintilla.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                    {
                        scintilla.BraceBadLight(bracePos1);
                        scintilla.HighlightGuide = 0;
                    }
                    else
                    {
                        scintilla.BraceHighlight(bracePos1, bracePos2);
                        scintilla.HighlightGuide = scintilla.GetColumn(bracePos1);
                    }
                }
                else
                {
                    // Turn off brace matching
                    scintilla.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                    scintilla.HighlightGuide = 0;
                }
            }
        }
    }
}
