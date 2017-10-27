using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {
	public int distance;
	public GameObject body;
	public GameObject gforward;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		finding (0,1);
		finding (1,0);
		finding (-1, 0);
		finding (0, 0);
		finding(0.5f,0);
		finding(-0.5f,0);
		finding(0.25f,0);
		finding(0,0);
		finding(1,1);
	}
	void finding(float right,float up ){
		float llong;
		Vector3 me;
		GameObject meobj = GameObject.Find ("RigidBodyFPSController");
		me = meobj.transform.position;
		Vector3 direction = me - this.transform.position;
		llong = Vector3.Distance (this.transform.position,me);
		direction.Normalize ();

		Ray ray = new Ray (this.transform.position,me);
////		Vector3 forward = gforward.transform.position - this.transform.position;
////		Ray ray = new Ray(this.transform.position,forward );
////		RaycastHit hitinfo;c
		Debug.DrawLine (ray.origin, ray.direction*llong, Color.red);
////		if (Physics.Raycast (ray, out hitinfo, distance)) {
////
////			Debug.DrawLine (ray.origin, hitinfo.point, Color.red);}
	}
}