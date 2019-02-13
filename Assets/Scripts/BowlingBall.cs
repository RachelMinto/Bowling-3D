using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {
    [SerializeField] AudioSource rollingSFX;
    private Rigidbody ballRigidbody;

	void Start () {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.useGravity = false;
	}

    public void Launch(Vector3 velocity) {
        ballRigidbody.useGravity = true;
        ballRigidbody.velocity = velocity;

        rollingSFX.Play();
    }
}
