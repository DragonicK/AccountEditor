using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace AccountEditor {
    public static class Configuration {
        private const string FilePath  = "Configuration.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        public static void WriteValue(string Section, string Key, string Value) {
            WritePrivateProfileString(Section, Key, Value, Environment.CurrentDirectory + "\\" + FilePath);
        }

        public static string ReadValue(string Section, string Key) {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Environment.CurrentDirectory + "\\" + FilePath);
            return temp.ToString();
        }

        public static void CheckFile() {
            if (!File.Exists(Environment.CurrentDirectory + "\\" + FilePath)) {
                WriteValue("MySQL", "Server", "127.0.0.1");
                WriteValue("MySQL", "Database", "crystalshire");
                WriteValue("MySQL", "Uid", "root");
                WriteValue("MySQL", "Pwd", "");
                WriteValue("MySQL", "MinimumPoolSize", "1");
                WriteValue("MySQL", "MaximumPoolSize", "100");
            }
        }
    }
}