using HedgeLib;
using HedgeLib.IO;
using HedgeLib.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicColorsSetEditor
{
    public class Config
    {
        public static string DolphinExecutablePath = "";

        public static void SaveConfig(string filePath)
        {
            using (var stream = File.OpenWrite(filePath))
            {
                SaveConfig(stream);
            }
        }

        public static void SaveConfig(Stream stream)
        {
            var writer = new ExtendedBinaryWriter(stream, true);
            writer.WriteSignature("SCSE");

            writer.WriteNullTerminatedString(DolphinExecutablePath);
            writer.FixPadding();
        }

        public static void LoadConfig(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var stream = File.OpenRead(filePath))
                {
                    LoadConfig(stream);
                }
            }
        }

        public static void LoadConfig(Stream stream)
        {
            var reader = new ExtendedBinaryReader(stream, true);
            string sig = reader.ReadSignature();
            if (sig != "SCSE")
                throw new InvalidSignatureException("SCSE", sig);

            DolphinExecutablePath = reader.ReadNullTerminatedString();
            reader.FixPadding();
        }

    }
}
