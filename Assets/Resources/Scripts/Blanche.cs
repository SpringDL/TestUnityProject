using UnityEngine;
using System.Collections;

public class Blanche : MonoBehaviour {

	private Universe universeSS;
	private LakituCam lakituCamSS;

	//Player States
	public bool grounded = true;
	public bool jump = false;
	public bool[] dir8 = new bool[] {false, false, false, false, false, false, false, false, false, false};

	//SpeedMod - Do Not Touch
	private float wSpeedMod = 1.71f;
	private float aSpeedMod = -2.15f;
	private float sSpeedMod = 1.29f;
	private float dSpeedMod = -2.15f;
	private float qeSpeedMod = -0.4f;
	private float zcSpeedMod = -0.65f;

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
		Debug.Log(rigidbody.velocity.magnitude);
		//FaceDir();
	}

	//
	void LateUpdate () {

	}
	
	//
	void FixedUpdate () {
		rigidbody.velocity = new Vector3(velX, velY, velZ);
	}

	//
	void FaceDir () {


		//W
		if (universeSS.key_W && !universeSS.key_A && !universeSS.key_D){
			dir8[8] = true;
		}else
		//WD
		if (universeSS.key_W && universeSS.key_D){
			dir8[9] = true;
		}else
		//D
		if (universeSS.key_D && !universeSS.key_W && !universeSS.key_S){
			dir8[6] = true;
		}else
		//SD
		if (universeSS.key_S && universeSS.key_D){
			dir8[3] = true;
		}else
		//S
		if (universeSS.key_S && !universeSS.key_A && !universeSS.key_D){
			dir8[2] = true;
		}else
		//SA
		if (universeSS.key_S && universeSS.key_A){
			dir8[1] = true;
		}else
		//A
		if (universeSS.key_A && !universeSS.key_W && !universeSS.key_S){
			dir8[4] = true;
		}else
		//WA
		if (universeSS.key_W && universeSS.key_A){
			dir8[7] = true;
		}else{
			dir8[8] = false;
			dir8[9] = false;
			dir8[6] = false;
			dir8[3] = false;
			dir8[2] = false;
			dir8[1] = false;
			dir8[4] = false;
			dir8[7] = false;
		}


		//NOTHING
		if (!universeSS.key_W && !universeSS.key_A && !universeSS.key_S && !universeSS.key_D){

		}
	}


	//
	void CheckInput () {
		//W
		if (universeSS.key_W && !universeSS.key_A && !universeSS.key_D){
			velX = lakituCamSS.LookAt8().x * (speed + wSpeedMod);
			velZ = lakituCamSS.LookAt8().z * (speed + wSpeedMod);
		}
		//WD
		if (universeSS.key_W && universeSS.key_D){
			velX = lakituCamSS.LookAt9().x * (speed + qeSpeedMod);
			velZ = lakituCamSS.LookAt9().z * (speed + qeSpeedMod);
		}
		//D
		if (universeSS.key_D && !universeSS.key_W && !universeSS.key_S){
			velX = lakituCamSS.LookAt6().x * (speed + dSpeedMod);
			velZ = lakituCamSS.LookAt6().z * (speed + dSpeedMod);
		}
		//SD
		if (universeSS.key_S && universeSS.key_D){
			velX = lakituCamSS.LookAt3().x * (speed + zcSpeedMod);
			velZ = lakituCamSS.LookAt3().z * (speed + zcSpeedMod);
		}
		//S
		if (universeSS.key_S && !universeSS.key_A && !universeSS.key_D){
			velX = lakituCamSS.LookAt2().x * (speed + sSpeedMod);
			velZ = lakituCamSS.LookAt2().z * (speed + sSpeedMod);
		}
		//SA
		if (universeSS.key_S && universeSS.key_A){
			velX = lakituCamSS.LookAt1().x * (speed + zcSpeedMod);
			velZ = lakituCamSS.LookAt1().z * (speed + zcSpeedMod);
		}
		//A
		if (universeSS.key_A && !universeSS.key_W && !universeSS.key_S){
			velX = lakituCamSS.LookAt4().x * (speed + aSpeedMod);
			velZ = lakituCamSS.LookAt4().z * (speed + aSpeedMod);
		}
		//WA
		if (universeSS.key_W && universeSS.key_A){
			velX = lakituCamSS.LookAt7().x * (speed + qeSpeedMod);
			velZ = lakituCamSS.LookAt7().z * (speed + qeSpeedMod);
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
