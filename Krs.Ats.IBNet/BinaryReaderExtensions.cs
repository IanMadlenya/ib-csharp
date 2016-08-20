using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public static class BinaryReaderExtensions
    {
        public static string ReadStr(this BinaryReader reader)
        {
            StringBuilder buf = new StringBuilder();
            while (true)
            {
                sbyte c = (sbyte)reader.ReadByte();
                if (c == 0)
                {
                    break;
                }
                buf.Append((char)c);
            }

            string str = buf.ToString();
            return str.Length == 0 ? null : str;
        }

        public static int ReadInt(this BinaryReader reader)
        {
            string str = reader.ReadStr();

            return str == null ? 0 : int.Parse(str, CultureInfo.InvariantCulture);
        }

        public static bool ReadBoolFromInt(this BinaryReader reader)
        {
            string str = reader.ReadStr();
            return str == null ? false : (int.Parse(str, CultureInfo.InvariantCulture) != 0);
        }
    }
}
