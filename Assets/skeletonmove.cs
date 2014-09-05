using UnityEngine;
using System.Collections;
public class skeletonmove : MonoBehaviour
{
	public Transform spine;




	void Start ()
	{
	}
	void Update ()
	{

		Vector3 rot = spine.rotation.eulerAngles;
		// Detect key input and add or subtract from the x rotation (scaling
		// by deltaTime to make this speed independent from the frame rate)
		if (Input.GetKey (KeyCode.K) && rot.y > 266) {
			//			rot.y -= Time.deltaTime * 50.0f;
				
				//		this.transform.Translate (Vector3.left * 0.1f);



				} else
		
		if (Input.GetKey (KeyCode.L) && rot.y < 274) {
			//			rot.y += Time.deltaTime * 50.0f;
				//		this.transform.Translate (-Vector3.left * 0.1f);

				} else {


				}


		if(!Input.GetKey(KeyCode.L)&&!Input.GetKey(KeyCode.K))
		if(rot.y<270)
		{
			
			rot.y+=Time.deltaTime*10;
		}
		else
			
			if(rot.y>270)
		{
			
			rot.y-=Time.deltaTime*10;
		}

		
		
		print ("This is log so ... "+rot.y);


		// Apply the new rotation
		spine.rotation = Quaternion.Euler(rot);



		//		spine.localRotation = Quaternion.Euler (rot);
	} 


}

