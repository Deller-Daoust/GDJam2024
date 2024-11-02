using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SlotPrize2 : MonoBehaviour
{
    [SerializeField] Transform transform;
    [SerializeField] SlotMachine slotMachine;
    [SerializeField] SlotMachine.prizeColour _prizecolour;

    void Start()
    {
            if(transform.position.y > 0){
                transform.position = new Vector3(transform.position.x,2);
            }
            else if (transform.position.y < 0){
                transform.position = new Vector3(transform.position.x,-2);
            }
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if player is lower than the boundaries allow
        if (transform.position.y <= (-slotMachine.MoveBound)){
            //If they are lower than the boundaries, then they get warped back to the top
            transform.position = new Vector2(transform.position.x,slotMachine.MoveBound);
        }

        //Checks if slot machine is spinning
        if (slotMachine.getSpin()){
            transform.position = transform.position + new Vector3(0,-slotMachine.slotSpeed* Time.deltaTime);
        }
        //if machine has stopped
        else if(!slotMachine.getHardStop())
        {
            //Prize will keep moving until oppoximately centered
            if (transform.position.y < -0.2 || transform.position.y > 0.2){
                transform.position = transform.position + new Vector3(0,-slotMachine.slotSpeed* Time.deltaTime);
            }
            else{
                //Stop the whole slot maching
                slotMachine.stopSlots();
                transform.position = new Vector3(transform.position.x,0);
                slotMachine.setWinningColour(_prizecolour);
            }
        }
        if(slotMachine.getHardStop()){
            if(transform.position.y > 0){
                transform.position = new Vector3(transform.position.x,2);
            }
            else if (transform.position.y < 0){
                transform.position = new Vector3(transform.position.x,-2);
            }
        }

    }
}
