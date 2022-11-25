namespace Composite;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		var file1 =
			FileSystem.File.Create(name: "File-01", size: 10);

		var file2 =
			FileSystem.File.Create(name: "File-02", size: 20);

		var file3 =
			FileSystem.File.Create(name: "File-03", size: 3);

		var file4 =
			FileSystem.File.Create(name: "File-04", size: 15);

		var selectedFiles =
			new
			System.Collections.Generic.List<FileSystem.IFileSystem>
			{ file1, file2, file4 };

		var filesSize =
			selectedFiles[0].GetSize() +
			selectedFiles[1].GetSize() +
			selectedFiles[2].GetSize();

		System.Console.WriteLine
			(value: $"{nameof(FileSystem.File)}: {filesSize}");

		var directory =
			FileSystem.Directory.Create(fileSystems: selectedFiles);

		var directorySize =
			directory.GetSize();

		System.Console.WriteLine
			(value: $"{nameof(FileSystem.Directory)}: {directorySize}");
	}
}
