using UnityEngine;

public class GameTileContent : MonoBehaviour
{

    GameTileContentFactory originFactory;
    public GameTileContentFactory OriginFactory
    {
        get => originFactory;
        set
        {
            Debug.Assert(originFactory == null, "Redefined origin factory!");
            originFactory = value;
        }
    }

    public void Recycle()
    {
        originFactory.Reclaim(this);
    }
    [SerializeField]
    GameTileContentType type = default;
    public enum GameTileContentType
    {
        Empty, Destination
    }
    public GameTileContentType Type => type;

}
