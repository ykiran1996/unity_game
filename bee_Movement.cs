using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class bee_Movement : MonoBehaviour {
	public GameObject bee;
	float x;
	
	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "ball" || col.gameObject.name == "ball1" || col.gameObject.name == "ball1(Clone)" || col.gameObject.name == "ball(Clone)") {
			SceneManager.LoadScene ("game_over");	

		}
	}

	public void Update()
	{
		//x = Input.GetAxis ("Horizontal");
		x=Input.acceleration.x;
		bee.transform.Translate (new Vector2 (x,0.0f) * Time.deltaTime * 15.0f);

	}
		

		
}
