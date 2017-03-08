using UnityEngine;
using System.Collections;

public class TextImporter : MonoBehaviour 
{
	public TextAsset TextFile;
	public string[] DialogueLines;

	// Use this for initialization
	void Start () 
	{
		if (TextFile != null) 
		{
			DialogueLines = (TextFile.text.Split('\n'));
		}
	}
}
