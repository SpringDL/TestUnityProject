using UnityEngine;
using System.Collections;

public class Universe : MonoBehaviour {

	//Input
	public bool key_W = false;
	public bool key_A = false;
	public bool key_S = false;
	public bool key_D = false;
	public bool key_Space = false;
	public bool key_F = false;
	public bool key_J = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckKeys();
	}

	//
	public void CheckKeys () {
		key_W = Input.GetKey(KeyCode.W);
		key_A = Input.GetKey(KeyCode.A);
		key_S = Input.GetKey(KeyCode.S);
		key_D = Input.GetKey(KeyCode.D);
		key_Space = Input.GetKey(KeyCode.Space);
		key_F = Input.GetKey(KeyCode.F);
		key_J = Input.GetKey(KeyCode.J);
	}
}
