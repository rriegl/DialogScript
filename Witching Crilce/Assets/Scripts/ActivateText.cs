using UnityEngine;
using System.Collections;

public class ActivateText : MonoBehaviour {

	public TextAsset NewTextFile;

	public int StartLine;
	public int EndLine;

	public DialogManager NewDialogManager;

	// Use this for initialization
	void Start () 
	{
		NewDialogManager = FindObjectOfType<DialogManager> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
