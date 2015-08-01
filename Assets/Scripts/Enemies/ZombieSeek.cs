using UnityEngine;
using System.Collections;

public class ZombieSeek : MonoBehaviour {

	private Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		//Find the closest player
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
		GameObject target = null;
		if(targets.Length != 0)
		{
			target = targets[0];
		}

		foreach(GameObject temp in targets){
			if((target.transform.position - transform.position).magnitude > (temp.transform.position - transform.position).magnitude){
				target = temp;
			}
		}

		Vector3 dir = target.transform.position - transform.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg - 90.0f;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		rb.AddForce(transform.up);
	}
}
