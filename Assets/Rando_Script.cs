using UnityEngine;
using System.Collections;

public class Rando_Script : MonoBehaviour {

	public string message = "Bonjour Monde!";
	// Use this for initialization
	void Start () {
		Debug.Log ("Hello, World!");
		GetComponent<TextMesh> ().text = message;
		// Display hello world in French slang in our 3D Text
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
