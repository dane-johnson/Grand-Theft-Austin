using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector3 (mousePos.x, mousePos.y, -3);
	}
}
