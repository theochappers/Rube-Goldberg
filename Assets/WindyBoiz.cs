using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindyBoiz : MonoBehaviour {
    public float launcher;
        private void OnTriggerStay (Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * launcher, ForceMode.Acceleration);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
