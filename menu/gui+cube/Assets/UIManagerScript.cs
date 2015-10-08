using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public void StartGame() {
		Application.LoadLevel("main");
	}
	public Animator startButton;
	
	public Animator settingsButton;

	public Animator quitButton;

	public Animator dialog;

	public void OpenSettings()
		
	{
		
		startButton.SetBool("isHidden", true);
		
		settingsButton.SetBool("isHidden", true);

		quitButton.SetBool("isHidden", true);
		dialog.enabled = true;
		
		dialog.SetBool("isHidden", false);

		
	}


	public void CloseSettings()
		
	{
		
		startButton.SetBool("isHidden", false);
		
		settingsButton.SetBool("isHidden", false);

		quitButton.SetBool("isHidden", false);
		
		dialog.SetBool("isHidden", true);
		
	}

}
