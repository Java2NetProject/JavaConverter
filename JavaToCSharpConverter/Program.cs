using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCSharpConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStream = new Antlr4.Runtime.AntlrFileStream(args[0]);
            var lexer = new Antlr4.Languages.Java.Java8Lexer(inputStream);
            var ts = new Antlr4.Runtime.CommonTokenStream(lexer);
            var parser = new Antlr4.Languages.Java.Java8Parser(ts);
            var walker = new Antlr4.Runtime.Tree.ParseTreeWalker();
 


        }
    }
}
