using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace challenge02
{
    public class ENIGMA_CODE 
    {
        public static bool vali              = true;
        public static int contador           = 0;
        public static int x                  = 0;
        public static string exa             = string.Empty;
        public static string encrypted       = string.Empty;
        public static List<string> decrypted = new List<string>();

        public static void Main()
        {
            CODE_TESTs.tests pruebas = new CODE_TESTs.tests();
            pruebas.exe(/*num2*/);
        }
    }
}