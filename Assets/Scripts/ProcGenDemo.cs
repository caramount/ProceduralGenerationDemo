using UnityEngine;
using System.Collections;

using System.Collections.Generic; // we're going to add this line so we can use "lists"

public class ProcGenDemo : MonoBehaviour {

	public Transform prefab;
	public List<Transform> listOfClones = new List<Transform>();

	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < 200; i++)
		{
			Transform newClone = (Transform)Instantiate(
				prefab, 
				Random.insideUnitSphere * 5f, 
				Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
			newClone.localScale = new Vector3(
				Random.Range(0.5f, 1f), 
				Random.Range(0.5f, 2f), 
				Random.Range(0.5f, 1f));
			listOfClones.Add(newClone);
			//Debug.Log(i.ToString());
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			foreach (Transform clone in listOfClones)
			{
				clone.localScale *= 2f;
			}
		}
	}
}
