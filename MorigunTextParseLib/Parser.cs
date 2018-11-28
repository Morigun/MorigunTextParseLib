using MorigunTextParseLib.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MorigunTextParseLib
{
    public class Parser
    {
        static void Main()
        {
            String inputText = File.ReadAllText("test.txt");            
            Parser parser = new Parser(inputText, Encoding.UTF8);            
            System.Diagnostics.Debug.Print($"{parser.CntAllSymbols}");
            foreach (var str in parser.CntSymbol)
                System.Diagnostics.Debug.Print($"{parser.ByteToString(str.Key)}:{str.Value}");                
        }

        private readonly String _inputText;
        private List<byte[]> _byteArray;
        public int CntAllSymbols { get; private set; }
        public Dictionary<byte[], int> CntSymbol { get; private set; }
        public Encoding CurrentEncoding { get; set; }
        public List<Word> Words { get; private set; }
        private DictionaryOfLiterals dict { get; set; }

        public Parser(String inputText, Encoding encoding)
        {
            CurrentEncoding = encoding;
            dict = Newtonsoft.Json.JsonConvert.DeserializeObject<DictionaryOfLiterals>(File.ReadAllText("DictionaryOfLiterals.d"));
            _inputText = inputText;
            _byteArray = new List<byte[]>();
            foreach (var ch in _inputText)
                _byteArray.Add(CurrentEncoding.GetBytes(new[] { ch }));
            CntAllSymbols = _byteArray.Count;
            var tmpData = _byteArray.GroupBy(a => a, new ArrayComparer<byte>()).Select(a => new
            {
                Symbol = a.Key,
                Cnt = a.Count()
            });
            CntSymbol = new Dictionary<byte[], int>();
            foreach (var td in tmpData)
                CntSymbol.Add(td.Symbol, td.Cnt);

            Words = new List<Word>();
            /*Words*/
            var patterns = dict.Items.FirstOrDefault(a => a.Name.Equals("word")).Patterns;
            foreach(var pattern in patterns)
                foreach(var match in Regex.Matches(_inputText, pattern))
                    Words.Add(new Word { Value = match.ToString() });
            
        }

        public String ByteToString(byte[] val)
        {
            return CurrentEncoding.GetString(val);
        }

        public static String ByteToString(byte[] val, Encoding encoding)
        {
            return encoding.GetString(val);
        }
    }
}
