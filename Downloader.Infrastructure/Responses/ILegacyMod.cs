namespace Downloader.Infrastructure.Responses;

public interface ILegacyMod : IBaseMod
{
    string Domain { get; }
    string FileName { get; }
    string State { get; }
    IEnumerable<string> DependsOn { get; }
}