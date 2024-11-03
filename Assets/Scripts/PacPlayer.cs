using UnityEngine;

public class PacPlayer : MonoBehaviour
{
    private PacMove _pacMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _pacMove = GetComponent<PacMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            _pacMove.SetDirection("left");
        }
        else if (Input.GetKey(KeyCode.Keypad6))
        {
            _pacMove.SetDirection("right");
        }
        else if (Input.GetKey(KeyCode.Keypad8))
        {
            _pacMove.SetDirection("up");
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            _pacMove.SetDirection("down");
        }
    }
}
