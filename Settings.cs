using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LoginSignup
{
    class Settings
    {
        public string iniPath = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel32", CharSet = CharSet.Auto)]

        private static extern int GetPrivateProfileString(String sectionName, string KeyName, String defaultValue, StringBuilder returnedString, int Size, string fileName);
        [DllImport("Kernel32")]

        private static extern long WritePrivateProfileString(String section, String keyname, string value, string path);

        public StringBuilder sbTheme;

        public string theme { get; set; }

        public void readIni()
        {
            int resultSize;
            sbTheme = new StringBuilder(10);
            resultSize = GetPrivateProfileString("SECTION", "key", "", sbTheme, sbTheme.Capacity, iniPath);

            this.theme = sbTheme.ToString();

        }
        public void writeIni(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
