using UnityEngine;
using System.Collections;

public class CastFireball : MonoBehaviour {

	public GameObject fireboat;

	// Use this for initialization
	void Start () {
		fireboat = Resources.Load<GameObject>("Prefabs/Fireball");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)){
			GameObject.Instantiate(fireboat, transform.position, Quaternion.identity);
		}
	}
}
