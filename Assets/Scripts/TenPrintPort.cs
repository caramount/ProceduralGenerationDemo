using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TenPrintPort : MonoBehaviour {

	public Text myText;
	private int counter = 0;
	// Use this for initialization
	void Start () 
	{
		//Set random seed
		Random.seed = 1;
//		int counter = 0;
//		while (counter < 2000)
//		{
//			myText.text += Random.Range(0f, 100f) > 50f ? "/" : "\\";
//			counter++;
//			//Debug.Log(counter.ToString());
//		}
	}
	void Update()
	{
		if (counter < 500)
		{
			myText.text += Random.Range(0f, 100f) > 50f ? "/" : "\\";
			counter++;					
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
