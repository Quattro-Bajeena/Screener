using Game.Enums;

namespace Game.Models;

public class GameImage
{
    public string Path { get; set; }
    public List<string> Answers { get; set; }
    public MediaSource SourceType { get; set; }
    public int? SourceId { get; set; }
    public int TimesShown { get; set; }
}
