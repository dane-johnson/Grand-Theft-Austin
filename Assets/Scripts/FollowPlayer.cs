using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{

	private GameObject player;

	void Start ()
	{
		StartCoroutine("FindPlayer");
	}

	IEnumerator FindPlayer(){
		do {
			player = GameObject.FindGameObjectWithTag ("Player");
			yield return null;
		} while (player == null);
	}

	void Update ()
	{
	
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, transform.position.z);

	}
}
