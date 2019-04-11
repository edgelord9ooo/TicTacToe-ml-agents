using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    private GameController gameController;
    
    public void setSpace () 
    {
        
        buttonText.text = gameController.GetPlayerSide();
        if (String.IsNullOrEmpty(buttonText.text)) {
            return;
        }
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference (GameController controller)
    {
        gameController = controller;
    }
}
