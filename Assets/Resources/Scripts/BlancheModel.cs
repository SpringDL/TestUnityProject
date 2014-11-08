using UnityEngine;
using System.Collections;

public class BlancheModel : MonoBehaviour {

	private Universe universeSS;

	// Use this for initialization
	void Start () {
		universeSS = GameObject.Find("Universe").GetComponent<Universe>();
	}
	
	// Update is called once per frame
	void Update () {
		FaceDirection();
	}

	//
	void FaceDirection () {
		//W
		if (universeSS.key_W && !universeSS.key_A && !universeSS.key_D){
			transform.LookAt(GameObject.Find("Dir8").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//WD
		if (universeSS.key_W && universeSS.key_D){
			transform.LookAt(GameObject.Find("Dir9").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//D
		if (universeSS.key_D && !universeSS.key_W && !universeSS.key_S){
			transform.LookAt(GameObject.Find("Dir6").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//SD
		if (universeSS.key_S && universeSS.key_D){
			transform.LookAt(GameObject.Find("Dir3").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//S
		if (universeSS.key_S && !universeSS.key_A && !universeSS.key_D){
			transform.LookAt(GameObject.Find("Dir2").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//SA
		if (universeSS.key_S && universeSS.key_A){
			transform.LookAt(GameObject.Find("Dir1").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//A
		if (universeSS.key_A && !universeSS.key_W && !universeSS.key_S){
			transform.LookAt(GameObject.Find("Dir4").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
		//WA
		if (universeSS.key_W && universeSS.key_A){
			transform.LookAt(GameObject.Find("Dir7").transform);
			transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
		}
	}
}
