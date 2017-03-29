using UnityEngine;
using System.Collections;

public class TerrainGen : MonoBehaviour {

	public GameObject TerrainPrefab;

	public int x;
	public int z;
	public int SpawnDir;
	public int MaxTerrainTiles;

	// Use this for initialization
	void Start () {
		//Creates a plane, moves in a random direction, checks if its full. If not, Repeats from the beginning.
		for (int i = 0; i < MaxTerrainTiles; i++) {
			if (Physics.CheckBox (new Vector3 (x, 0, z), Vector3.zero) == false) {
				Instantiate (TerrainPrefab, new Vector3 (x, 0, z), Quaternion.identity);
				int RandomNumber = Random.Range (0, 3);
				if (RandomNumber == 0) {
					x += 5;
				} 
				if (RandomNumber == 1) {
					z += 5;
				}
				if (RandomNumber == 2) {
					x -= 5;
				}
				if (RandomNumber == 3) {
					z -= 5;
				}

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
