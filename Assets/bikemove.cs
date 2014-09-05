using UnityEngine;
using System.Collections;

public class bikemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public Transform target;

	public float degrees=120;

	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.K) ) {

			this.transform.Translate (Vector3.left * 0.1f);
			
			transform.RotateAround (target.position, Vector3.down, degrees * Time.deltaTime);

			
		} else
			
		if (Input.GetKey (KeyCode.L) ) {

			this.transform.Translate (-Vector3.left * 0.1f);

			transform.RotateAround (target.position, Vector3.forward, -degrees * Time.deltaTime);

		} 



	
	}
}
