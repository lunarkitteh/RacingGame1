using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PickTrackAndBaby : MonoBehaviour {
	private int index = 0;
	public List<Sprite> images;
	public SpriteRenderer spriteRender;


	public void RightButtonClicked(){
		if (index < images.Count-1) {
			index++;
		} else {
			index = 0;
		}
		spriteRender.sprite = images [index];

	}

	public void LeftButtonClicked(){
		index--;
		if (index < 0) {
			index = images.Count - 1;
		}
		spriteRender.sprite = images [index];
	}


	public void StartButtonClicked(){
		// open photon lobby
		SceneManager.LoadScene ("Lobby6Players");
		DontDestroyOnLoad (spriteRender);
	}
	public void BackButtonClicked(){
		// open photon lobby
		SceneManager.LoadScene ("Matchmaking3Babies");
	}
		
}
