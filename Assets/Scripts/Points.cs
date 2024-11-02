using UnityEngine;

public class Points : MonoBehaviour
{
    public int tetrisPoints;
    public bool canSpinSlots = false;

    public int slotPoints;
    public bool canSpinGacha = false;

    public int gachaPoints;

    public void Update()
    {
        if (tetrisPoints > 100)
        {
            canSpinSlots = true;
        }

        if (slotPoints > 100)
        {
            canSpinGacha = true;
        }
    }
}
