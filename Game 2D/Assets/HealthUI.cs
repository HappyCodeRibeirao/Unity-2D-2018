using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    int counter = 0;
    //  Imagem no GUI do JOGO
    public Image heartUI;

    // Array de imgens
    public Sprite[] vidasArray = new Sprite[6];

    void Start()
    {
        //heartUI.sprite = vidasArray[2];

        
    }

    void Update()
    {
        if (Input.GetKeyDown("left ctrl") && counter < 5)
        {
            counter = counter + 1;
            heartUI.sprite = vidasArray[counter];
        }

    }
}
