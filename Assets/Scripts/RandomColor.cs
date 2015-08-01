using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {


	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		renderer.sprite = sprites[(int)(Random.value * 4)];
		GetComponent<Rigidbody2D>().AddForce(transform.up * 300);
	}
}
