using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;
	public TextAsset textFile;
	public string[] textLines;
	public int currentLine;
	public int endAtLine;
	public bool isActive;

	// Use this for initialization
	void Start () {

		if(textFile != null)
		{
			textLines = (textFile.text.Split('\n'));

		}
		if(endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;

		}
		if(isActive)
		{
			EnableTextBox();
		}
		else
		{
			DisableTextBox();
		}
	}

	void Update()
	{
		if(!isActive)
		{
			return;
		}

		theText.text = textLines[currentLine];
		if(Input.GetButtonDown ("Use"))
		{
			currentLine += 1;
		}
		if(currentLine > endAtLine)
		{
			DisableTextBox();
		}
	}

	public void EnableTextBox()
	{
		textBox.SetActive(true);
	}	

	public void DisableTextBox()
	{
		textBox.SetActive(false);
	}
}
