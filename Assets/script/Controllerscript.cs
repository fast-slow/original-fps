using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllerscript : MonoBehaviour {
	public Camera raycamera;
	public int distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Shot ();
	}
	void Shot(){
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
	Ray ray = raycamera.ScreenPointToRay (center);
		RaycastHit hitinfo;
		if (Physics.Raycast (ray, out hitinfo, distance)) {
//			Debug.Log ("hit");
			Debug.DrawLine (ray.origin, hitinfo.point, Color.red);}
	}
}
