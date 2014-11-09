using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	private Universe universeSS;
	public Vector3 rotationSwordSwing1 = new Vector3 (0, 180, 0);
	public bool swinging = false;
	public float swingSpeed = 10f;
	public GameObject sword;

	// Use this for initialization
	void Start () {
		universeSS = GameObject.Find("Universe").GetComponent<Universe>();
		sword = GameObject.Find("Sword");
		transform.localEulerAngles = rotationSwordSwing1;
		sword.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		CheckInput();
		//Debug.Log (transform.rotation.y);
	}

	//
	void CheckInput () {
		if (universeSS.key_J && !swinging){
			StartCoroutine("Swing");
		}

	}

	IEnumerator Swing () {
		swinging = true;
		sword.GetComponent<MeshRenderer>().enabled = true;
		do{
			transform.Rotate(0, -swingSpeed, 0);
			yield return null;
		}while(transform.localEulerAngles.y >= 1f);
		yield return new WaitForSeconds(0.1f);
		sword.GetComponent<MeshRenderer>().enabled = false;
		transform.localEulerAngles = rotationSwordSwing1;
		swinging = false;
	}
}
