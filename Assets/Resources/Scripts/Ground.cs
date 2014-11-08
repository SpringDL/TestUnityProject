using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	private GameObject player;
	private Blanche playerSS;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Blanche");
		playerSS = player.GetComponent<Blanche>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//
	void OnTriggerStay (Collider other) {
		if (other.gameObject == player && player.transform.position.y > this.transform.position.y){
			playerSS.grounded = true;
		}
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject == player){
			playerSS.grounded = false;
		}
	}
}
