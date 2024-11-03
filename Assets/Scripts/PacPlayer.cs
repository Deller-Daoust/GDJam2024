using UnityEngine;
using UnityEngine.Tilemaps;

public class PacPlayer : MonoBehaviour
{
    private PacMove _pacMove;
    
    public Tile tile;
    public Board board;
    public Vector3Int position;
    public Tilemap tilemap;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.tilemap.SetTile(position, tile);
        //_pacMove = GetComponent<PacMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            DirectionalMove(Vector2Int.left);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            DirectionalMove(Vector2Int.right);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            DirectionalMove(Vector2Int.up);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            DirectionalMove(Vector2Int.down);
        }
    }

    private void DirectionalMove(Vector2Int direction)
    {
        this.tilemap.SetTile(position, null);
            
        Vector2Int toMove = direction;
        Vector3Int newPosition = this.position;

        newPosition.x += toMove.x;
        newPosition.y += toMove.y;
        
        if (this.tilemap.GetTile(newPosition) != null)
            UIManager.Instance.UpdateScore(50);
            
        Move(direction);
        this.tilemap.SetTile(position, tile);
    }
    
    private void Move(Vector2Int translation) {
        Vector3Int newPosition = this.position;
        newPosition.x += translation.x;
        newPosition.y += translation.y;
        
        this.position = newPosition;
    }
}
