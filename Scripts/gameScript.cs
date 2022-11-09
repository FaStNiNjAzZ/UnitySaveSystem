using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameScript : MonoBehaviour
{
    public static int counter = 0;

    public Text counterText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = Convert.ToString(counter);
    }

    public static void ButtonCounter()
    {
        counter += 1;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        counter = data.counter;
    }
}