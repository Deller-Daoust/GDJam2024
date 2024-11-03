using UnityEngine;

public class PacMove : MonoBehaviour
{
    public GameObject currentNode;
    public float speed = 4f;

    public string direction = "";
    public string lastMoveingDirection = "";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NodeController currentNodeController = currentNode.GetComponent<NodeController>();

        transform.position = Vector2.MoveTowards(transform.position, currentNode.transform.position, speed * Time.deltaTime);

        bool reverseDirection = false;
        if 
        (
            (direction == "left" && lastMoveingDirection == "right")
            || (direction == "right" && lastMoveingDirection == "left")
            || (direction == "up" && lastMoveingDirection == "down")
            || (direction == "down" && lastMoveingDirection == "up")
        )
        {
            reverseDirection = true;
        }
        
        if ((transform.position.x == currentNode.transform.position.x &&
            transform.position.y == currentNode.transform.position.y) || reverseDirection)
        {
            GameObject newNode = currentNodeController.GetNodeFromDirection(direction);
            if (newNode != null)
            {
                currentNode = newNode;
                lastMoveingDirection = direction;
            }
            else
            {
                direction = lastMoveingDirection;
                newNode = currentNodeController.GetNodeFromDirection(direction);
                if (newNode != null)
                {
                    currentNode = newNode;
                }
            }
        }
    }

    public void SetDirection(string newDirection)
    {
        direction = newDirection;
    }
}
