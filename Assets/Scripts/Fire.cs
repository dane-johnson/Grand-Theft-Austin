using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public float speed;
	public float clearDist;

	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if(Mathf.Abs((transform.position - mousePos).magnitude) > clearDist){
		
		//Rotate Sprite to look at mouse
		float AngleRad = Mathf.Atan2 (mousePos.y - rb.position.y, mousePos.x - rb.position.x);
		float angle = ((180.0f / Mathf.PI) * AngleRad + 90.0f);
		transform.rotation = Quaternion.Euler(0, 0, angle);

		}

		rb.AddForce(-transform.up * speed);
	
	}
}
