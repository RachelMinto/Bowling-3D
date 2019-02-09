using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {
    [SerializeField] AudioSource rollingSFX;

	void Start () {
        Vector3 initialVelocity = new Vector3(0, 0, -350);
        GetComponent<Rigidbody>().velocity = initialVelocity;
	}
}
