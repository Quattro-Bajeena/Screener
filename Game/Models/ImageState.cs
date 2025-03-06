namespace Game.Models;

public class ImageState
{
    public GameImage Image { get; set; }
    public bool[,] RevealedTiles { get; set; }
}
