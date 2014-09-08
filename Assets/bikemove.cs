using UnityEngine;
using System.Collections;

public class bikemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		speed = 1;
		moveThreshold = 0.2f;

		movex = 0;

<<<<<<< HEAD
		delay = 0.005f;

=======
>>>>>>> FETCH_HEAD
	}


	public Transform target;

	public float degrees=0;


	bool goleft,goright;




<<<<<<< HEAD
	float speed,moveThreshold,movex,iPx,delay,accel;
=======
	float speed,moveThreshold,movex,iPx;
>>>>>>> FETCH_HEAD


	// Update is called once per frame
	void Update () {


		iPx = Input.acceleration.x;




/*
	

		if(Mathf.Abs (iPx)>moveThreshold)
		{


			movex=Mathf.Sign (iPx)*speed;

			this.transform.Translate (Vector3.left * (movex));



		}

*/



<<<<<<< HEAD
		if (Input.GetKey (KeyCode.K)||iPx>delay) {
=======
		if (Input.GetKey (KeyCode.K)||iPx<-0.05f) {
>>>>>>> FETCH_HEAD
			goleft = true;
			goright = false;
			
		} else
<<<<<<< HEAD
		if (Input.GetKey (KeyCode.L)||iPx<-delay) {
=======
		if (Input.GetKey (KeyCode.L)||iPx>0.05f) {
>>>>>>> FETCH_HEAD
			goleft = false;
			goright = true;
			
		} else {
			goleft=false;
			goright=false;
			
		}



		if (Mathf.Abs (iPx) < 1) {
						accel = iPx/2;
				}



	//	if (Input.GetKey (KeyCode.K)) {
		if(goleft)
		{

<<<<<<< HEAD
			if(Mathf.Abs(iPx)>delay)
						this.transform.Translate (Vector3.left * (-(accel-delay)));
=======
						this.transform.Translate (Vector3.left * (-iPx/2));
>>>>>>> FETCH_HEAD
		
		//	this.transform.Translate (Vector3.left * (0.05f));


						//	transform.RotateAround (target.position, Vector3.down, degrees * Time.deltaTime);
			//			degrees += 0.005f;
			
				} else
			
//		if (Input.GetKey (KeyCode.L)) {
			if(goright)
		{
			if(Mathf.Abs(iPx)>delay)
						this.transform.Translate (Vector3.left * (-(accel+delay)));


			//this.transform.Translate (Vector3.left * (-0.05f));

<<<<<<< HEAD

=======
						this.transform.Translate (Vector3.left * (-iPx/2));


			//this.transform.Translate (Vector3.left * (-0.05f));


>>>>>>> FETCH_HEAD
			//			degrees += 0.005f;

						//		transform.RotateAround (target.position, Vector3.forward, -degrees * Time.deltaTime);

				} else {
			degrees=0;
				}







		print (""+transform.position.x);


	
	}
}
