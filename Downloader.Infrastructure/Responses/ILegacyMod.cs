namespace Downloader.Infrastructure.Responses;

public interface ILegacyMod : IBaseMod
{
    string Domain { get; set; }
    string FileName { get; set; }
    string State { get; set; }
    IEnumerable<string> DependsOn { get; set; }
}