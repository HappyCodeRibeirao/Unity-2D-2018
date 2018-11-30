using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] heartSprite;

    public Image heartUI;

    private int counter;

	void Start ()
    {
        counter = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown("left alt")  && counter<=5)
        {
            heartUI.sprite = heartSprite[counter];
            counter++;
        }
    }
}
