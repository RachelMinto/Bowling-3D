using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {
    [SerializeField] AudioSource rollingSFX;
    public Vector3 launchVelocity;
    private Rigidbody ballRigidbody;

	void Start () {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.velocity = launchVelocity;
        GetComponent<Rigidbody>().velocity = launchVelocity;

        Debug.Log(rollingSFX);
        rollingSFX.Play();
	}
}
