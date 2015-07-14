using System.IO.Compression;

public class Unzip {
	static void Main(string[] args) {
		ZipFile.ExtractToDirectory(args[0], ".");
	}
}
