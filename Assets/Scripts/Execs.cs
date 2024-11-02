using UnityEngine;
using UnityEngine.Tilemaps;

public enum Execs
{
    Lauren_L,
    Ruidger_I,
    Lucas_T,
    Logan_Z,
    Dean_S,
    KC_O,
    Mikey_J
}

[System.Serializable]
public struct ExecData
{
    public Execs exec;
    public Tile[] tiles;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.exec];
    }
}