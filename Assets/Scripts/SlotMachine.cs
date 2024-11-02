using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    [SerializeField] public float MoveBound;
    [SerializeField] public float slotSpeed;
    public bool isSpinning = true;
    public bool hardStop;
    [SerializeField] GameObject prize1;
    [SerializeField] GameObject prize2;
    [SerializeField] GameObject prize3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hardStop = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle on and off the spinning with space
        if (Input.GetKeyDown("space")){
            if(getSpin()){
                isSpinning = false;
            }
            else{
                isSpinning = true;
                hardStop = false;
            }
        }
    }

    public bool getSpin(){
        return isSpinning;
    }
    public void stopSlots(){
        hardStop = true;
    }
    public bool getHardStop(){
        return hardStop;
    }
}
