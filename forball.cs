using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class forball : MonoBehaviour {
	private Vector2 pos;
	public GameObject obj,obj1;
	public void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "ball(Clone)")
			col.gameObject.name = "ball";
		
		if (col.gameObject.name=="ball") {
			Destroy (col.gameObject,0.1f);
			pos.x = Random.Range(-7.38f,7.38f);
			pos.y = 5.88f;
			Instantiate (obj,pos,obj.transform.rotation);
			//Destroy (col.gameObject);
		}


		if (col.gameObject.name == "ball1(Clone)")
			col.gameObject.name = "ball1";
		
		if (col.gameObject.name=="ball1") {
			Destroy (col.gameObject,0.1f);
			pos.x = Random.Range(-7.38f,7.38f);
			pos.y = 5.88f;
			Instantiate (obj1,pos,obj1.transform.rotation);
			//Destroy (col.gameObject);
		}
	}
}
