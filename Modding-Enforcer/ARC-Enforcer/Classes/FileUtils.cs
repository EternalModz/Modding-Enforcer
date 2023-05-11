using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ARC_Enforcer
{
	public class FileUtils
	{
		internal static byte[] smethod_0(string string_0)
		{
			byte[] array = null;
			bool flag = File.Exists(string_0);
			if (flag)
			{
				using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
				{
					long length = binaryReader.BaseStream.Length;
					binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
					array = new byte[length];
					binaryReader.Read(array, 0, (int)length);
				}
			}
			return array;
		}

		internal static string smethod_1(string string_0, string string_1, string string_2, string string_3 = "")
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string result = null;
			string_2 = FileUtils.smethod_2(string_2);
			openFileDialog.DefaultExt = string_0;
			openFileDialog.Filter = string_1;
			openFileDialog.InitialDirectory = string_2;
			openFileDialog.FileName = string_3;
			DialogResult dialogResult = openFileDialog.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				result = openFileDialog.FileName;
			}
			return result;
		}

		private static string smethod_2(string string_0)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(string_0);
				if (flag)
				{
					string_0 = Path.GetDirectoryName(string_0);
				}
			}
			catch (Exception)
			{
			}
			return string_0;
		}

		internal static string smethod_3(string string_0, string string_1, string string_2, string string_3 = "")
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string result = null;
			saveFileDialog.DefaultExt = string_0;
			saveFileDialog.Filter = string_1;
			saveFileDialog.InitialDirectory = string_2;
			saveFileDialog.FileName = string_3;
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				result = saveFileDialog.FileName;
			}
			return result;
		}

		internal static string smethod_4(string string_0, string string_1 = "Conversion output folder")
		{
			string result = null;
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = string_1;
				folderBrowserDialog.ShowNewFolderButton = true;
				folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
				folderBrowserDialog.SelectedPath = string_0;
				bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					result = folderBrowserDialog.SelectedPath;
				}
			}
			return result;
		}

		internal static string smethod_5(string string_0)
		{
			string text = string_0;
			int num = text.LastIndexOf('\\');
			bool flag = num > 0;
			if (flag)
			{
				text = text.Substring(num + 1);
			}
			num = text.LastIndexOf('.');
			bool flag2 = num > 0;
			if (flag2)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		public static void WriteFile(MemoryStream stream, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				byte[] buffer = stream.ToArray();
				binaryWriter.Write(buffer);
			}
		}

		public static void WriteFile(byte[] bytes, string filename)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filename, FileMode.Create)))
			{
				binaryWriter.Write(bytes);
			}
		}

		public static short ReadShort(BinaryReader reader)
		{
			byte[] array = new byte[2];
			array = reader.ReadBytes(2);
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (isLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt16(array, 0);
		}

		public static byte[] ReadBytes(BinaryReader reader, int fieldSize, FileUtils.ByteOrder byteOrder)
		{
			byte[] array = new byte[fieldSize];
			bool flag = byteOrder == FileUtils.ByteOrder.LittleEndian;
			byte[] result;
			if (flag)
			{
				result = reader.ReadBytes(fieldSize);
			}
			else
			{
				for (int i = fieldSize - 1; i > -1; i--)
				{
					array[i] = reader.ReadByte();
				}
				result = array;
			}
			return result;
		}

		public static uint smethod_6(BinaryReader reader, FileUtils.ByteOrder byteOrder)
		{
			bool flag = byteOrder == FileUtils.ByteOrder.LittleEndian;
			uint result;
			if (flag)
			{
				result = (uint)reader.ReadInt32();
			}
			else
			{
				result = BitConverter.ToUInt32(FileUtils.ReadBytes(reader, 4, FileUtils.ByteOrder.BigEndian), 0);
			}
			return result;
		}

		public static void smethod_7(BinaryWriter writer, uint value, FileUtils.ByteOrder byteOrder)
		{
			byte[] array = BitConverter.GetBytes(value);
			bool flag = byteOrder == FileUtils.ByteOrder.BigEndian;
			if (flag)
			{
				array = array.Reverse<byte>().ToArray<byte>();
			}
			writer.Write(array);
		}

		internal static void smethod_8(string string_0)
		{
			foreach (string path in Directory.GetFiles(string_0))
			{
				File.Delete(path);
			}
		}

		internal static void smethod_9(string string_0)
		{
			bool flag = !Directory.Exists(string_0);
			if (flag)
			{
				Directory.CreateDirectory(string_0);
			}
		}

		public static string CheckFolderSep(string folderPath)
		{
			bool flag = folderPath != null && !folderPath.EndsWith("\\");
			if (flag)
			{
				folderPath += "\\";
			}
			return folderPath;
		}

		public static bool CheckFolderExists(string folderPath)
		{
			folderPath = FileUtils.CheckFolderSep(folderPath);
			return Directory.Exists(folderPath);
		}

		internal static void smethod_10(string string_0)
		{
			bool flag = File.Exists(string_0);
			if (flag)
			{
				File.Delete(string_0);
			}
		}

		internal static void smethod_11(string string_0, string string_1)
		{
			bool flag = File.Exists(string_0);
			if (flag)
			{
				File.Move(string_0, string_1);
			}
		}

		internal static void smethod_12(string string_0, string string_1)
		{
			bool flag = File.Exists(string_0);
			if (flag)
			{
				bool flag2 = File.Exists(string_1);
				if (flag2)
				{
					FileUtils.smethod_10(string_1);
				}
				File.Copy(string_0, string_1);
			}
		}

		public static void CopyFoldersAndFiles(string source, string target)
		{
			DirectoryInfo source2 = new DirectoryInfo(source);
			DirectoryInfo target2 = new DirectoryInfo(target);
			FileUtils.CopyFoldersAndFiles(source2, target2);
		}

		public static void CopyFoldersAndFiles(DirectoryInfo source, DirectoryInfo target)
		{
			ARC_Classes @class = new ARC_Classes();
			foreach (DirectoryInfo directoryInfo in source.GetDirectories())
			{
				FileUtils.CopyFoldersAndFiles(directoryInfo, target.CreateSubdirectory(directoryInfo.Name));
			}
			foreach (FileInfo fileInfo in source.GetFiles())
			{
				@class.method_0(fileInfo.FullName, Path.Combine(target.FullName, fileInfo.Name));
			}
		}

		internal static long smethod_13(string string_0)
		{
			FileInfo fileInfo = new FileInfo(string_0);
			return fileInfo.Length;
		}

		public FileUtils()
		{
			Class50.dTjArREzVyevQ();
		}

		public enum ByteOrder
		{
			LittleEndian,
			BigEndian
		}
	}
}
