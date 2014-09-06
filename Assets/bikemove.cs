using UnityEngine;
using System.Collections;

public class bikemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public Transform target;

	public float degrees=0;


	bool goleft,goright;


	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.K)||Input.acceleration.x>0.2f) {
			goleft = true;
			goright = false;
			
		} else
		if (Input.GetKey (KeyCode.L)||Input.acceleration.x<-0.2f) {
			goleft = false;
			goright = true;
			
		} else {
			goleft=false;
			goright=false;
			
		}





	//	if (Input.GetKey (KeyCode.K)) {
		if(goleft)
		{

						this.transform.Translate (Vector3.left * (0.1f+degrees));
			
						//	transform.RotateAround (target.position, Vector3.down, degrees * Time.deltaTime);
						degrees += 0.005f;
			
				} else
			
//		if (Input.GetKey (KeyCode.L)) {
			if(goright)
		{

						this.transform.Translate (-Vector3.left * (0.1f+degrees));

						degrees += 0.005f;

						//		transform.RotateAround (target.position, Vector3.forward, -degrees * Time.deltaTime);

				} else {
			degrees=0;
				}



	
	}
}
