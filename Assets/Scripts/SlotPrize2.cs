using UnityEngine;

public class SlotPrize2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform transform;
    [SerializeField] SlotMachine slotMachine;
    void Start()
    {
        rb.AddForce(new Vector2(0,slotMachine.initialVelocity));
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if player is lower than the boundaries allow
        if (transform.position.y <= (-slotMachine.MoveBound)){
            //If they are lower than the boundaries, then they get warped back to the top
            transform.position = new Vector2(transform.position.x,slotMachine.MoveBound);
        }
        if (Input.GetKeyDown("space"))
        {
            //Stops rotation
            rb.AddForce(new Vector2(0,-slotMachine.initialVelocity));
        }

    }
}
