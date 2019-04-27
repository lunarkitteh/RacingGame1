using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinCreateThree : MonoBehaviour {
	
	void Start(){
		
	}
	public void CreateThree(){
		SceneManager.LoadScene ("CreateThree");
	}

	public void JoinThree(){
		SceneManager.LoadScene ("JoinThree");
	}
	public void BackButtonOnJoinCreate(){
		// open photon lobby
		SceneManager.LoadScene ("Menu");
	}
}
