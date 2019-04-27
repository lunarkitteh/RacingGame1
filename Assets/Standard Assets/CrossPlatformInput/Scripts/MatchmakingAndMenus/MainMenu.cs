using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public void AllTheSingleBabies(){
		SceneManager.LoadScene ("PickingBabyAndLocation");
	}
	public void ThreeBabies(){
		SceneManager.LoadScene ("Matchmaking3Babies");
	}
	public void Matchmaking4vs4(){
		SceneManager.LoadScene ("Matchmaking4vs4");
	}
}