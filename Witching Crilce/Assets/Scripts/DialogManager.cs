using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour 
{
	public GameObject DialogBox;
	public GameObject CharacterNameBox;
	public Text CharacterDialog;
	public Text CharacterName;

	public bool DialogBoxActive;
	public bool CharacterNameBoxActive;

	public string[] DialogLines;
	public int CourrentLine; // keeps track of courent line

	// Use this for initialization
	void Start () 
	{
		FindObjectsOfType<DialogManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (DialogBoxActive && Input.GetKeyDown(KeyCode.Space)) 
		{
			 	CourrentLine++; // increment lines 
		}
		if (CourrentLine >= DialogLines.Length) 
		{
			DialogBox.SetActive (false);
			DialogBoxActive = false;

			CourrentLine = 0;
		}
		CharacterDialog.text = DialogLines [CourrentLine];
	}
	public void ShowDialogBox(string Dialog)
	{
		DialogBoxActive = true;
		DialogBox.SetActive(true);
		CharacterDialog.text = Dialog;
	}
}
