using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {
	
	Vector3 flyingPath = new Vector3(0, 0, 0);
	public float speed = 15f;

	private GameObject pModel;

	// Use this for initialization
	void Start () {
		pModel = GameObject.Find("Model");
		flyingPath = pModel.transform.forward;
		StartCoroutine("TimeToDie");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(flyingPath * speed * Time.deltaTime);
	}

	IEnumerator TimeToDie (){
		yield return new WaitForSeconds(2f);
		GameObject.Destroy(this.gameObject);
	}
}
