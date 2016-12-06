using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	public Texture backgroundTextureCredits;


	void OnGUI(){

		//Anzeigen der Hintergrundtexture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTextureCredits);

		if (Input.GetKey (KeyCode.W)) { //Oberer Button lädt Spiel

			Application.LoadLevel ("MainMenu");
		}

		if (Input.GetKey (KeyCode.U)) {

			Application.LoadLevel ("MainMenu");

		}
	}
}
