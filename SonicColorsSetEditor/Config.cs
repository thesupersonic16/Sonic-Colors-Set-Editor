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
        public static string GameRootPath = "";
        public static short ConfigVersion = 2;

        public static void SaveConfig(string filePath)
        {
            using (var stream = File.OpenWrite(filePath))
                SaveConfig(stream);
        }

        public static void SaveConfig(Stream stream)
        {
            var writer = new ExtendedBinaryWriter(stream, true);
            writer.WriteSignature("SCSE");
            writer.Write(ConfigVersion);
            writer.WriteNullTerminatedString(DolphinExecutablePath);
            writer.WriteNullTerminatedString(GameRootPath);
        }

        public static void LoadConfig(string filePath)
        {
            if (File.Exists(filePath))
                using (var stream = File.OpenRead(filePath))
                    LoadConfig(stream);
        }

        public static void LoadConfig(Stream stream)
        {
            var reader = new ExtendedBinaryReader(stream, true);
            string sig = reader.ReadSignature();
            if (sig != "SCSE")
                throw new InvalidSignatureException("SCSE", sig);

            if (reader.ReadUInt16() != ConfigVersion)
            { // Old Config
                stream.Close();
                File.Delete(((FileStream)stream).Name);
                return;
            }

            DolphinExecutablePath = ReadEntry(reader);
            GameRootPath = ReadEntry(reader);
        }

        public static string ReadEntry(ExtendedBinaryReader reader)
        {
            if (reader.BaseStream.Position < reader.BaseStream.Length)
                return reader.ReadNullTerminatedString();
            return "";
        }

    }
}
