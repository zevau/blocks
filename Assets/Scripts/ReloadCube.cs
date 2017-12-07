using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadCube : MonoBehaviour {

	public FiducialController Fiducial;
	public GameManager Manager;

	bool FirstTime = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (FirstTime && Fiducial.IsVisible) {
			FirstTime = false;
			Manager.Reload ();
		}
	}
}
