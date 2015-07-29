using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorPrefab;
	public Transform wallPrefab;
	public Transform pathMaker;

	private float chanceOfPathMaker;

	// Use this for initialization
	void Start () 
	{
		chanceOfPathMaker = Random.Range(0.0f, 1.0f);
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				Vector3 pos = new Vector3(i*5, 0, j*5);
				pos += transform.position;
				float randy = Random.Range(0.0f, 1.0f);
				if (randy < 0.7f)
				{
					Instantiate(floorPrefab, pos, transform.rotation);
				}
				else if (randy < 0.95f)
				{
					Instantiate(wallPrefab, pos, transform.rotation);
				}
			}
		}
		if (Random.Range(0.0f, 1.0f) < chanceOfPathMaker)
		{
			Instantiate(pathMaker, transform.position, transform.rotation);
		}
		Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
