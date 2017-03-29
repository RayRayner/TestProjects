using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float Countdown;
	public float CountdownMax;
	NavMeshAgent nma;

	public GameObject[] Nodes;

	// Use this for initialization
	void Awake () {

		Nodes = GameObject.FindGameObjectsWithTag ("Node");
		
		nma = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {

		Countdown -= Time.deltaTime;

		if (Countdown <= 0) {
			GameObject TravelNode;
			int Randy = Random.Range (0, Nodes.Length);
			TravelNode = Nodes [Randy];
			nma.SetDestination (TravelNode.transform.position);
			Countdown = CountdownMax;
		}
	
	}
}
