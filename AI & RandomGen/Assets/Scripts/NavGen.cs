using UnityEngine;
using System.Collections;

public class NavGen : MonoBehaviour {

	public NavMesh navMesh;

	// Use this for initialization
	void Awake () {

		navMesh = new NavMesh ();
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
