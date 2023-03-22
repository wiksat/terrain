using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

private Text show;
private int score = 0;
	// Use this for initialization
	void Start () {
		show = GameObject.Find("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		show.text = "Punkty: "+score;
	}
	public int GetScore(){
		return score;
	}
	public void AddScore(){
		score++;
	}
}
