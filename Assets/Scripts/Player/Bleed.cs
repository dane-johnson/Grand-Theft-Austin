using UnityEngine;
using System.Collections;

public class Bleed : MonoBehaviour {

	public int drops;
	public GameObject drop;

	private bool bleeding = false;
	private float startTime;

	void Start()
	{
		startTime = Time.time;
	}

	void OnCollisionEnter2D(Collision2D collider){
		if(collider.gameObject.tag == "Enemy"){
			bleeding = true;
			Spurt();
		} else if (collider.gameObject.tag == "Bullet"){
			Spurt();
		}
	}

	void OnCollisionExit2D(Collision2D collider){
		if(collider.gameObject.tag == "Enemy"){
			bleeding = false;
		}
	}

	void FixedUpdate(){
		if(bleeding && startTime - Time.time % 1 == 0){
			Spurt();
		}
	}

	void Spurt(){
		for(int i = 0; i < drops; i++){
			drop.transform.position = new Vector3(transform.position.x + (Random.value * 0.5f) - 0.25f, transform.position.y + (Random.value * 0.5f) - 0.25f, 1);
			drop.transform.rotation = Quaternion.AngleAxis(Random.value * 360.0f, Vector3.forward);
			GameObject myDrop = Instantiate(drop);

			//Add the drop to the total count
			ManageGibs mg = GameObject.FindGameObjectWithTag("GameController").GetComponent<ManageGibs>();
			mg.AddToBloodStack(myDrop);
		}
	}
}
