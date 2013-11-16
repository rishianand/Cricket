using UnityEngine;
using System.Collections;

public class bat : MonoBehaviour {
	
	private Vector3 initPosition;
	private Quaternion initRotation;
	
	public float swingForce;
	// Use this for initialization
	void Start () {
		initPosition = transform.position;
		initRotation = transform.rotation;
		rigidbody.useGravity = false;
		rigidbody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("up") && !Input.GetButtonDown("off") && !Input.GetButtonDown("leg")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(0,0,-swingForce);
		}else if(!Input.GetButtonDown("up") && Input.GetButtonDown("off") && !Input.GetButtonDown("leg")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(swingForce,0,0);
		}else if(!Input.GetButtonDown("up") && !Input.GetButtonDown("off") && Input.GetButtonDown("leg")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(-swingForce,0,0);
		}else if(Input.GetButtonDown("up") && Input.GetButtonDown("off") && !Input.GetButtonDown("leg")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(swingForce,0,-swingForce);
		}else if(Input.GetButtonDown("up") && !Input.GetButtonDown("off") && Input.GetButtonDown("leg")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(-swingForce,0,-swingForce);
		}
		if(Input.GetButtonUp("reset")){
			rigidbody.useGravity = false;
			rigidbody.freezeRotation = true;
			transform.position = initPosition;
			transform.rotation = initRotation;
		}
	}
}
