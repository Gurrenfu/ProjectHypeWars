﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public MultiPlayerManager multiPlayerManager;
    public Text healthText;
  

    void Update()
    {
        if (multiPlayerManager.playerStatsList.Count > 1)
            healthText.text =  "P1 Score: " + multiPlayerManager.playerStatsList[0].Score.ToString() + ", P2 Score: " + multiPlayerManager.playerStatsList[1].Health.ToString();
        else if(multiPlayerManager.playerStatsList.Count > 0)
            healthText.text = "P1 Score: " + multiPlayerManager.playerStatsList[0].Score.ToString();

    }
}
