using UnityEngine;
using System.Collections;

public class SelectPlayer : MonoBehaviour {

	public Sprite[] sprites;
	public static int spriteNo;

	void Start(){

		UpdateSprite();

	}

	public void UpdateSprite(){
		//get the man his sprite
		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		sr.sprite = sprites[spriteNo];
	}
}
