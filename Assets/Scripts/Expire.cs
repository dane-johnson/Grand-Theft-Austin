using UnityEngine;
using System.Collections;

public class Expire : MonoBehaviour {

	float startTime;

	// Use this for initialization
	void Start () {

		startTime = Time.time;
	
	}
	
	void FixedUpdate(){

		float currentTime = Time.time;
		if(currentTime - startTime > 3){
			Destroy(gameObject);
		}

	}
}
