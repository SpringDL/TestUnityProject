using UnityEngine;
using System.Collections;

public class Blanche : MonoBehaviour {

	private Universe universeSS;
	private LakituCam lakituCamSS;

	//Player States
	public bool grounded = true;
	public bool jump = false;

	//Var
	private float speed = 0;
	public float groundSpeed = 25f;
	public float airSpeed = 15f;
	public float gravity = -20f;
	public float jumpStrengh = 25f;
	public float jumpFloatTime = 0.05f;
	
	private float velX = 0f;
	private float velY = 0f;
	private float velZ = 0f;
	
	// Use this for initialization
	void Start () {
		universeSS = GameObject.Find("Universe").GetComponent<Universe>();
		lakituCamSS = GameObject.Find("Lakitu").GetComponent<LakituCam>();
	}
	
	// Update is called once per frame
	void Update () {
		CheckInput();
		//Debug.Log(rigidbody.velocity.magnitude);
		//FaceDir();
	}
	
	//
	void FixedUpdate () {
		rigidbody.velocity = new Vector3(velX, velY, velZ);
	}

	//
	void CheckInput () {
		//W
		if (universeSS.key_W && !universeSS.key_A && !universeSS.key_D){
			velX = lakituCamSS.LookAt8().x * speed;
			velZ = lakituCamSS.LookAt8().z * speed;
		}
		//WD
		if (universeSS.key_W && universeSS.key_D){
			velX = lakituCamSS.LookAt9().x * speed;
			velZ = lakituCamSS.LookAt9().z * speed;
		}
		//D
		if (universeSS.key_D && !universeSS.key_W && !universeSS.key_S){
			velX = lakituCamSS.LookAt6().x * speed;
			velZ = lakituCamSS.LookAt6().z * speed;
		}
		//SD
		if (universeSS.key_S && universeSS.key_D){
			velX = lakituCamSS.LookAt3().x * speed;
			velZ = lakituCamSS.LookAt3().z * speed;
		}
		//S
		if (universeSS.key_S && !universeSS.key_A && !universeSS.key_D){
			velX = lakituCamSS.LookAt2().x * speed;
			velZ = lakituCamSS.LookAt2().z * speed;
		}
		//SA
		if (universeSS.key_S && universeSS.key_A){
			velX = lakituCamSS.LookAt1().x * speed;
			velZ = lakituCamSS.LookAt1().z * speed;
		}
		//A
		if (universeSS.key_A && !universeSS.key_W && !universeSS.key_S){
			velX = lakituCamSS.LookAt4().x * speed;
			velZ = lakituCamSS.LookAt4().z * speed;
		}
		//WA
		if (universeSS.key_W && universeSS.key_A){
			velX = lakituCamSS.LookAt7().x * speed;
			velZ = lakituCamSS.LookAt7().z * speed;
		}
		//NOTHING
		if (!universeSS.key_W && !universeSS.key_A && !universeSS.key_S && !universeSS.key_D){
			velX = 0;
			velZ = 0;
		}

		//Jump
		if (universeSS.key_Space && grounded){
			StartCoroutine("Jump");
		}

		//Changing speed ground vs air
		if (grounded){
			velY = gravity;
			speed = groundSpeed;
		}else{
			speed = airSpeed;
		}
	}

	//  Le Jump
	IEnumerator Jump () {
		grounded = false;
		for (float j = jumpStrengh; j > 0; j -= 0.5f)
		{
			velY = j;
			yield return null;
		}
		yield return new WaitForSeconds(jumpFloatTime);
		
		for (float j = 0; j > gravity; j -= 0.5f)
		{
			velY = j;
			yield return null;
		}
	}
}
