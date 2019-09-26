using UnityEngine;

public class GameTileContent : MonoBehaviour
{
    GameTileContentFactory originFactory;
    public GameTileContentType Type => type;
    [SerializeField]
    GameTileContent destinationPrefab = default;

    [SerializeField]
    GameTileContent emptyPrefab = default;
    [SerializeField]
    GameTileContentType type = default;
    public enum GameTileContentType
    {
        Empty, Destination
    }
    public GameTileContent Get(GameTileContentType type)
    {
        switch (type)
        {
            case GameTileContentType.Destination: return Get(destinationPrefab);
            case GameTileContentType.Empty: return Get(emptyPrefab);
        }
        Debug.Assert(false, "Unsupported type: " + type);
        return null;
    }

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
}
