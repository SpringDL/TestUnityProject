using UnityEngine;
using System.Collections;

public class LakituCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 LookAt8 () {
		transform.LookAt(GameObject.Find("Dir8").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt9 () {
		transform.LookAt(GameObject.Find("Dir9").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt6 () {
		transform.LookAt(GameObject.Find("Dir6").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt3 () {
		transform.LookAt(GameObject.Find("Dir3").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt2 () {
		transform.LookAt(GameObject.Find("Dir2").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt1 () {
		transform.LookAt(GameObject.Find("Dir1").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt4 () {
		transform.LookAt(GameObject.Find("Dir4").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
	
	public Vector3 LookAt7 () {
		transform.LookAt(GameObject.Find("Dir7").transform);
		transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		return transform.forward;
	}
}
