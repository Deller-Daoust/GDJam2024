using System;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    [SerializeField] public float MoveBound;
    [SerializeField] public float slotSpeed;
    public bool isSpinning = false;
    public bool hardStop = true;
    [SerializeField] GameObject prize1;
    [SerializeField] GameObject prize2;
    [SerializeField] GameObject prize3;
    prizeColour winningColour;
    public enum prizeColour {
        red,blue,green,
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hardStop = true;
    }

    // Update is called once per frame
    public void startSpin(){
        isSpinning = true;
        hardStop = false;
    }
    public void stopSpin(){
        isSpinning = false;
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
    public void setWinningColour(prizeColour _prizecolour){
        winningColour = _prizecolour;
    }
    public prizeColour getWinningColour(){
        return winningColour;
    }
}
