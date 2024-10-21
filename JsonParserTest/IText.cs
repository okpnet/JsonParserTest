using System;
using System.Collections.Generic;
using System.Text;

namespace JsonParserTest
{
    /// <summary>
    /// 1文字づつ処理するインターフェイス
    /// </summary>
    public interface IText
    {
        /// <summary>
        /// 位置情報
        /// </summary>
        PositionInfo PositionInfo { get; }
        /// <summary>
        /// 現在位置の文字を取得する
        /// </summary>
        /// <returns>現在の位置の文字</returns>
        char Peek();
        /// <summary>
        /// 1文字進める
        /// </summary>
        void Advance();
    }
    /// <summary>
    /// ITextの拡張クラス
    /// </summary>
    public static class ITextExt
    {
        /// <summary>
        /// 1文字すすめて，現在位置の文字を返す
        /// </summary>
        /// <param name="itext">ITextインターフェイス</param>
        /// <returns></returns>
        public static char AdvacePeek(this IText itext)
        {
            itext.Advance();
            return itext.Peek();
        }
    }

}
