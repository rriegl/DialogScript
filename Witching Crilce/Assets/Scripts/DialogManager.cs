using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
	public GameObject DialogBox;
	public GameObject CharacterNameBox;
	public GameObject EnemyBox;
	public GameObject Red;
	public GameObject Witch;

	public Text CharacterDialog;
	public Text CharacterName;
	public Text EnemyDialog;
	public Text EnemyName;

	public bool DialogBoxActive = true; // initialises dialog box

	public TextAsset TextFile;
	public string[] DialogLines;

	public int CourrentLine; // keeps track of courent line
	public int EndLine; // stops script at the end of the text

	private string RedString = "RED";
	private string WitchString = "WITCH";
    private string EndString = "END";
    private string BothString = "BOTH";
    private string NoneString = "NONE";
    // Use this for initialization
    void Start () 
	{
		if (TextFile != null) 
		{
			DialogLines = (TextFile.text.Split ('\n'));
		}

		if (EndLine == 0)
		{
			EndLine = DialogLines.Length - 1;
		}
		DisableEnemyNameBox();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (DialogLines[CourrentLine].Contains(RedString))
		{
			DisableEnemyNameBox ();
			EnableCharacterNameBox ();
			CourrentLine++;
		}
		else if (DialogLines[CourrentLine].Contains(WitchString))
		{
			DisableCharacterNameBox ();
			EnableEnemyNameBox ();
			CourrentLine++;
		}
        else if (DialogLines[CourrentLine].Contains(BothString))
        {
            Debug.Log("BOTH");
            DialogBox.SetActive(true);
            CharacterNameBox.SetActive(true);
            EnemyBox.SetActive(true);
            CourrentLine++;
        }
        else if (DialogLines[CourrentLine].Contains(NoneString))
        {
            Debug.Log("NONE");
            DialogBox.SetActive(true);
            CharacterNameBox.SetActive(false);
            EnemyBox.SetActive(false);
            CourrentLine++;
        }
        else if (DialogLines[CourrentLine].Contains(EndString))
        {
            DialogBox.SetActive(false);
            CharacterNameBox.SetActive(false);
            EnemyBox.SetActive(false);
            //DialogBox.SetActive(false);
            DialogBoxActive = false;
        }

        if (DialogBoxActive == true && Input.GetKeyDown(KeyCode.Space)) 
		{
			 CourrentLine++; // increment lines 
		}
        /*
		if (CourrentLine > EndLine) //>= DialogLines.Length
		{
			DisableDialogBox ();
			DisableCharacterNameBox ();
			DisableEnemyNameBox ();
			CourrentLine = 0; // reset the line counter
		}
        */
		CharacterDialog.text = DialogLines [CourrentLine];
		if (DialogBoxActive == false) 
		{
			DisableCharacterNameBox ();
			DisableEnemyNameBox ();
		}
	}


	// turns on dialog, character and enemy name boxes
	public void EnableDialogBox ()
	{
		DialogBox.SetActive (true); // turns on dialog box
	}
	public void EnableCharacterNameBox ()
	{
		CharacterNameBox.SetActive (true); // turns on character name box
	}
	public void EnableEnemyNameBox()
	{
		EnemyBox.SetActive (true); // turns on enemy name box
	}
	//turns off dialog, character and enemy name boxes
	public void DisableDialogBox()
	{
		DialogBox.SetActive (false); // turns off dialog box
	}
	public void DisableCharacterNameBox()
	{
		CharacterNameBox.SetActive (false); // turns off character name box
	}
	public void DisableEnemyNameBox()
	{
		EnemyBox.SetActive (false); // Turns off enemy name box
	}

	//Reload the script with diffrent textfile for diffrent scenes????
	public void ReloadScript(TextAsset NewTextFile)
	{
		if (TextFile != null) 
		{
			DialogLines = new string[1];
			DialogLines = (NewTextFile.text.Split ('\n'));
		}
	}
}
