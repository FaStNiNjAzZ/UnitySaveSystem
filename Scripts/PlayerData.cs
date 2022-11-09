using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int counter;



    public PlayerData(gameScript gameScript)
    {
        counter = gameScript.counter;
    }
}