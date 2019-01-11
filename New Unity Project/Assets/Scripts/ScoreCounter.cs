using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    public int score;
    public Text scoretext;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          score = score + 1;
            ScoreUpdate();
        }
	}

    void ScoreUpdate()
    {
        scoretext.text = "Enemies killed:" + score;
    }
}
