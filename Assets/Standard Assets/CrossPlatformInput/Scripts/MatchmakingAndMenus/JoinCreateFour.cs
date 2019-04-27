using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JoinCreateFour : MonoBehaviour {
	public void CreateFour(){
		SceneManager.LoadScene ("CreateFour");
	}

	public void JoinFour(){
		SceneManager.LoadScene ("JoinFour");
	}

}
