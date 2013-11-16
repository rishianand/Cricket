using UnityEngine;
using System.Collections;

public class Bowling : MonoBehaviour {
	
	public float forceX;
	public float forceY;
	public float forceZ;
	public float torqueX;
	public float torqueY;
	public float torqueZ;
	public float maxZ = 13;
	
	private Vector3 initPosition;
	// Use this for initialization
	void Start () {
		initPosition=transform.position;
		rigidbody.useGravity = false;
		rigidbody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("bowl")){
			rigidbody.useGravity = true;
			rigidbody.freezeRotation = false;
			rigidbody.AddForce(forceX, forceY, forceZ);
			rigidbody.AddTorque(torqueX, torqueY, torqueZ);
		}
		if(Input.GetButtonUp("reset")){
			rigidbody.useGravity = false;
			rigidbody.freezeRotation = true;
			rigidbody.velocity = new Vector3(0,0,0);
			transform.rotation = new Quaternion(0,0,0,0);
			transform.position = initPosition;
		}
	}
}
