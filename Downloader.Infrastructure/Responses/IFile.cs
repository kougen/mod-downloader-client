namespace Downloader.Infrastructure.Responses;

public interface IHash
{
    string Value { get; }
    int Algo { get; }
}

public interface IFile
{
    int Id { get; }
    int GameId { get; }
    int ModId { get; }
    bool IsAvailable { get; }
    string DisplayName { get; }
    string FileName { get; }
    int ReleaseType { get; }
    int FileStatus { get; }
    IEnumerable<IHash> Hashes { get; }
    DateTime FileDate { get; }
    int FileLength { get; }
    int DownloadCount { get; }
    string DownloadUrl { get; }
    IEnumerable<string> GameVersions { get; }
}
