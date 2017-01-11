using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class forPoints : MonoBehaviour {

	public int score=0;
	private float last_time=0.0f;
	Text points;
	public void Update()
	{
		points = GetComponent<Text> ();
		if (Time.time - last_time >= 1.0f) {
			score = score + 1;
			last_time = Time.time;
		}
		points.text = "" + score;
		PlayerPrefs.SetInt ("score", score);
			

	}

}
