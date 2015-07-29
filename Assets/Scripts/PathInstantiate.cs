using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {

	public Transform floorPrefab;
	public Transform gridMaker;

	private int counter = 0;
	private float chanceOfGridMaker;

	// Use this for initialization
	void Start () 
	{
		chanceOfGridMaker = Random.Range(0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (counter < 50)
		{
			float randy = Random.Range(0.0f, 1.0f);
			if (randy < 0.25f)
			{	
				transform.Rotate(0, 90f, 0);
			}
			else if (randy < 0.5f)
			{
				transform.Rotate(0, -90f, 0);
			}
			Instantiate(floorPrefab, transform.position, transform.rotation);
			transform.Translate(0, 0, 5f);
			counter++;
		}
		else
		{
			if (Random.Range(0.0f, 1.0f) < chanceOfGridMaker)
			{
				Instantiate(gridMaker, transform.position, transform.rotation);
			}
			Destroy(this.gameObject);
		}
	}		
}
