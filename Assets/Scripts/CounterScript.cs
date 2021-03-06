﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour {

    public Text countText;
    public static int counter;

	// Use this for initialization
	void Start () {
        counter = 60;
        StartCoroutine(DecreaseTime());
    }

    IEnumerator DecreaseTime() {
        counter--;
        countText.text = counter.ToString();
        if (counter > 0)
        {
            yield return new WaitForSeconds(1);
            StartCoroutine(DecreaseTime());
        }
        else {
            GameController.GameResult = -1;
            GameController.GoToNextLevel();
        }
    }
}
