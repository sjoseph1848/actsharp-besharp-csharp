using System;
using System.Collections.Generic;

namespace Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Greet("english");
            Console.WriteLine(test);
        }

        public static string Greet(string language)
        {
            return (lang.ContainsKey(language)) 
                ? lang[language] 
                : "Welcome";
        }
    
    private static readonly Dictionary<string, string> lang = new Dictionary<string, string>
    {
        {"english", "Welcome"},
        {"czech", "Vitejte"},
        {"danish", "Velkomst"},
        {"dutch", "Welkom"},
        {"estonian", "Tere tulemast"},
        {"finnish", "Tervetuloa"},
        {"flemish", "Welgekomen"},
        {"french", "Bienvenue"},
        {"german", "Willkommen"},
        {"irish", "Failte"},
        {"italian", "Benvenuto"},
        {"latvian", "Gaidits"},
        {"lithuanian", "Laukiamas"},
        {"polish", "Witamy"},
        {"spanish", "Bienvenido"},
        {"swedish", "Valkommen"},
        {"welsh", "Croeso"}
    };
    
    }
}

