using System;
using System.Collections.Generic;
using System.Text;

namespace JsonParserTest
{
    /// <summary>
    /// 文字列中の位置に関する情報
    /// </summary>
    public class PositionInfo
    {
        /// <summary>
        /// 行の文字列
        /// </summary>
        public string Line { get; private set; }
        /// <summary>
        /// 文字列中の位置が何行目か
        /// </summary>
        public int LineNumber { get; private set; }
        /// <summary>
        /// 何文字目か
        /// </summary>
        public int LinePostion { get; private set; }

        public PositionInfo(string line, int lineNumber, int linePostion)
        {
            Line = line;
            LineNumber = lineNumber;
            LinePostion = linePostion;
        }
    }
}
