using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour {
    [SerializeField] AudioSource rollingSFX;
    private Rigidbody ballRigidbody;
    private float startXLocation = 0f;

	void Start () {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.useGravity = false;
	}

    public void Launch(Vector3 velocity) {
        ballRigidbody.useGravity = true;
        ballRigidbody.velocity = velocity;

        rollingSFX.Play();
    }

    public void MoveStart(float xNudge)
    {
        float updatedLocation = Mathf.Clamp(startXLocation - xNudge, -50, 50);
        startXLocation = updatedLocation;

        Vector3 newPosition = new Vector3(startXLocation, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
