using Antlr4.Runtime;

namespace JavaToCSharpConverter
{
    public class LexerErrorListener : IAntlrErrorListener<int>   
    {
        public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg,
            RecognitionException e)
        {
            
        }
    }
}