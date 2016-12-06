using UnityEngine;
using System.Collections;

public class Manual : MonoBehaviour {

	public Texture backgroundTexture;


	void OnGUI(){

		//Anzeigen der Hintergrundtexture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		if (Input.GetKey (KeyCode.W)) { //Oberer Button lädt Menü

			Application.LoadLevel ("MainMenu");
		}

		if (Input.GetKey (KeyCode.U)) {

			Application.LoadLevel ("MainMenu");

		}
	}
}
