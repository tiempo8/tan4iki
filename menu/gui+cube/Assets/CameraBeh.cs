using UnityEngine;
using System.Collections;

public class CameraBeh : MonoBehaviour {

	public float rotateSpeed = 5.0f;
	public float moveSpeed = 0.1f;
	public GameObject target;
	public float height = 2;
	public float far = 2;
	
	private float angle=0;
	private float angle2=0;
	
	bool forw = false;
	bool back = false;
	bool right = false;
	bool left = false;
	bool up = false;
	bool down = false;
 	
 	void Update() 
 	{
 		if(Input.GetKeyDown(KeyCode.UpArrow))
 			forw=true;
 		if(Input.GetKeyUp(KeyCode.UpArrow))
 			forw=false;
 		
 		if(Input.GetKeyDown(KeyCode.DownArrow))
 			back=true;
 		if(Input.GetKeyUp(KeyCode.DownArrow))
 			back=false;
 		
 		if(Input.GetKeyDown(KeyCode.LeftArrow))
 			left=true;
 		if(Input.GetKeyUp(KeyCode.LeftArrow))
 			left=false;
 		
 		if(Input.GetKeyDown(KeyCode.RightArrow))
 			right=true;
 		if(Input.GetKeyUp(KeyCode.RightArrow))
 			right=false;
 		
 		if(Input.GetKeyDown(KeyCode.Q))
 			up=true;
 		if(Input.GetKeyUp(KeyCode.Q))
 			up=false;
 		
 		if(Input.GetKeyDown(KeyCode.Z))
 			down=true;
 		if(Input.GetKeyUp(KeyCode.Z))
 			down=false;
 		
 		transform.position=(Quaternion.Euler(angle2,angle,0)*new Vector3(far,height,0))+target.transform.position;
 		transform.LookAt(target.transform);
 		
		if (Input.GetMouseButton(1)) 
		{
			angle+=Input.GetAxis("Mouse X")*rotateSpeed;
			angle2+=Input.GetAxis("Mouse Y")*rotateSpeed;
     	}
		
		if(forw)
			target.transform.position+=Vector3.forward*moveSpeed;
		if(back)
			target.transform.position+=Vector3.back*moveSpeed;
		if(left)
			target.transform.position+=Vector3.left*moveSpeed;
		if(right)
			target.transform.position+=Vector3.right*moveSpeed;
		if(up)
			target.transform.position+=Vector3.up*moveSpeed;
		if(down)
			target.transform.position+=Vector3.down*moveSpeed;
 	}
}
