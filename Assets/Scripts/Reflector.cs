using UnityEngine;
using System.Collections;

public class Reflector : MonoBehaviour {

	public float xRadius, yRadius;

	private Vector3 vertex;

	void Start(){

		vertex = transform.position;

	}

	public float GetPush(Vector3 pos){
		//If outside radius, no push

		if(!IsInRadius(pos)){
			return 0.0f;
		}

		return 1.0f;

	}

	private bool IsInRadius(Vector3 pos){

		return (((vertex.x - pos.x) * (vertex.x - pos.x))/(xRadius * xRadius)) +
			(((vertex.y - pos.y) * (vertex.y - pos.y))/(yRadius * yRadius)) <= 1;
	}

}
