using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;


	void OnGUI(){

		//Anzeigen der Hintergrundtexture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		if (Input.GetKey (KeyCode.W)) { //Oberer Button lädt Spiel

			Application.LoadLevel ("Scene 1");
		}

		if (Input.GetKey (KeyCode.U)) {

			Application.LoadLevel ("Scene 1");

		}

		if (Input.GetKey (KeyCode.A)) { //Linker Button lädt Anleitung

			Application.LoadLevel ("Manual");

		}

		if (Input.GetKey (KeyCode.H)) {

			Application.LoadLevel ("Manual");

		}

		if (Input.GetKey (KeyCode.D)) { //Rechter Button lädt Credits

			Application.LoadLevel ("Credits");

		}

		if (Input.GetKey (KeyCode.K)) {

			Application.LoadLevel ("Credits");

		}
			
	}
	

}
