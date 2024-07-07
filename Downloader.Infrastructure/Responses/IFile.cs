namespace Downloader.Infrastructure.Responses;

public interface IHash
{
    string Value { get; set; }
    int Algo { get; set; }
}

public interface IFile
{
    int Id { get; set; }
    int GameId { get; set; }
    int ModId { get; set; }
    bool IsAvailable { get; set; }
    string DisplayName { get; set; }
    string FileName { get; set; }
    int ReleaseType { get; set; }
    int FileStatus { get; set; }
    List<IHash> Hashes { get; set; }
    DateTime FileDate { get; set; }
    int FileLength { get; set; }
    int DownloadCount { get; set; }
    string DownloadUrl { get; set; }
    List<string> GameVersions { get; set; }
}
