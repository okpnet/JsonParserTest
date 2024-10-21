using System;
using System.Collections.Generic;
using System.Text;

namespace JsonParserTest
{
    /// <summary>
    /// 構文解析器
    /// </summary>
    public class Scanner
    {
        /// <summary>
        /// 文字列クラス
        /// </summary>
        public IText Text { get;protected set; }
        /// <summary>
        /// 現在の文字列
        /// </summary>
        public string Scan { get;protected set; }
        /// <summary>
        /// 現在位置の文字
        /// </summary>
        public char Current { get;protected set; }

        public Scanner(IText text)
        {
            Text = text;
        }
        /// <summary>
        /// 文字列を空にする
        /// </summary>
        public void Empty() => Scan = string.Empty;
        /// <summary>
        /// 現在の文字が述語を充足するか
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public bool Check(Func<char,bool> func)=>func(Current);
        /// <summary>
        /// 現在の文字列に追加する
        /// </summary>
        /// <param name="s"></param>
        public void Add(string s)=>Scan += s;
        /// <summary>
        /// 1文字すすめて現在の文字を更新する
        /// </summary>
        public void Advance()=>Current=Text.AdvacePeek();
        /// <summary>
        /// 現在位置の文字を追加し，1文字すすめて現在の文字を更新する
        /// </summary>
        public void AddAdvance()
        {
            Scan += Current;
            Advance();
        }

        public bool CheckAdvance(Func<char,bool> func)
        {
            if(Check(func))
            {
                Advance();
                return true;
            }
            return false;
        }
    }
}
