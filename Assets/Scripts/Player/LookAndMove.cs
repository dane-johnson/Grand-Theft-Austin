using UnityEngine;
using System.Collections;

public class LookAndMove : MonoBehaviour {
	
	private Rigidbody2D rb;
	private int bulletsNeeded = 0;

	public float speed;
	public GameObject bullet;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update(){
		if(Input.GetButtonDown("Fire1")){
			bulletsNeeded++;
		}
	}

	void FixedUpdate() {
		//First lets let him move

		//Get the movement axes
		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");

		//Let's move
		rb.AddForce(new Vector2(hMove * speed, vMove * speed));
	
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		//Rotate Sprite to look at mouse
		float AngleRad = Mathf.Atan2 (mousePos.y - rb.position.y, mousePos.x - rb.position.x);
		float angle = ((180.0f / Mathf.PI) * AngleRad) - 90.0f;
		transform.rotation = Quaternion.Euler(0, 0, angle);

		while(bulletsNeeded > 0){
			GameObject myBullet = GameObject.Instantiate(bullet);
			myBullet.transform.position = transform.FindChild("Tip").transform.position;
			myBullet.transform.rotation = Quaternion.Euler(0, 0, angle + 180.0f);
			bulletsNeeded--;
		}
	}
}
