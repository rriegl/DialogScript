using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour 
{
	public GameObject DialogBox;
	public GameObject CharacterNameBox;
	public GameObject EnemyBox;

	public Text CharacterDialog;
	public Text CharacterName;
	public Text EnemyDialog;


	public bool DialogBoxActive = true;
	public bool CharacterNameBoxActive = true;

	public string[] DialogLines;
	public int CourrentLine; // keeps track of courent line

	// Use this for initialization
	void Start () 
	{
		FindObjectsOfType<DialogManager> ();
		EnemyBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (DialogBoxActive == true && Input.GetKeyDown(KeyCode.Space)) 
		{
			 	CourrentLine++; // increment lines 
		}
		if (CourrentLine >= DialogLines.Length) 
		{
			//DialogBox.SetActive (false);
			//DialogBoxActive = false;

			//Destroy (CharacterNameBox);
			CharacterNameBox.SetActive (false);
			CharacterNameBoxActive = false;

			EnemyBox.SetActive (true);

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
