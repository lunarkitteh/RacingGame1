using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby6Players:MonoBehaviour {
	public SpriteRenderer[] Friends = new SpriteRenderer[5];
	private SpriteRenderer bla;
	public GameObject playerObejct;
	void Start(){
		playerObejct = GameObject.Find ("CreateThree/CanvasCharacter/pickCharacter/Character");
		bla = playerObejct.GetComponent (typeof(SpriteRenderer))as SpriteRenderer;
	}
}	
