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
            this.tilemap.SetTile(position, null);
            Move(Vector2Int.left);
            this.tilemap.SetTile(position, tile);
            
            //_pacMove.SetDirection("left");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            this.tilemap.SetTile(position, null);
            Move(Vector2Int.right);
            this.tilemap.SetTile(position, tile);
            //_pacMove.SetDirection("right");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            this.tilemap.SetTile(position, null);
            Move(Vector2Int.up);
            this.tilemap.SetTile(position, tile);
            //_pacMove.SetDirection("up");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            this.tilemap.SetTile(position, null);
            Move(Vector2Int.down);
            this.tilemap.SetTile(position, tile);
            //_pacMove.SetDirection("down");
        }
    }
    
    private void Move(Vector2Int translation) {
        Vector3Int newPosition = this.position;
        newPosition.x += translation.x;
        newPosition.y += translation.y;
        
        this.position = newPosition;
    }
}
