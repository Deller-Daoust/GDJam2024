using UnityEngine;
using System.Collections;

public class SlotMachineManager : MonoBehaviour
{
    int activeSlot;
    int slotCheck;
    [SerializeField] SlotMachine slot1;
    [SerializeField] SlotMachine slot2;
    [SerializeField] SlotMachine slot3;
    [SerializeField] SlotMachine slot4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activeSlot = 4;
    }

    IEnumerator outputWinOrLoss()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        if((slot1.getWinningColour() == slot2.getWinningColour())
        &&(slot2.getWinningColour() == slot3.getWinningColour())
        &&(slot3.getWinningColour() == slot4.getWinningColour())){
            Debug.Log("You Win");
            } else {
                Debug.Log("You lose");
            }
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")){
            switch (activeSlot){
                //Stop slot 1
                case 0:
                slot1.stopSpin();
                activeSlot++;
                break;
                //Stops slot 2
                case 1:
                slot2.stopSpin();
                activeSlot++;
                break;
                //Stops slot 3
                case 2:
                slot3.stopSpin();
                activeSlot++;
                break;
                //Stops slot 4
                case 3:
                slot4.stopSpin();
                activeSlot++;
                //Declare win or loss
                StartCoroutine(outputWinOrLoss());
                break;
                case 4:
                slot1.startSpin();
                slot2.startSpin();
                slot3.startSpin();
                slot4.startSpin();
                activeSlot = 0;
                break;              
            }
        }

    }
}
