using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krs.Ats.IBNet
{
    public static class BinaryWriterExtensions
    {
        private static readonly byte[] EOL = new byte[] { 0 };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="val"></param>
        public static void Send(this BinaryWriter writer, int val)
        {
            writer.Send(Convert.ToString(val, CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="val"></param>
        public static void Send(this BinaryWriter writer, bool val)
        {
            writer.Send(val ? 1 : 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="str"></param>
        public static void Send(this BinaryWriter writer, string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                writer.Write(ToByteArray(str));
            }
            writer.SendEOL();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        private static void SendEOL(this BinaryWriter writer)
        {
            writer.Write(EOL);
        }

        /// <summary>
        /// Converts a string to an array of bytes
        /// </summary>
        /// <param name="source">The string to be converted</param>
        /// <returns>The new array of bytes</returns>
        private static byte[] ToByteArray(String source)
        {
            return UTF8Encoding.UTF8.GetBytes(source);
        }
    }
}
