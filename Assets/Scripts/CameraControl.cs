using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public BowlingBall ball;

    private Vector3 offset = new Vector3(0, 100, 300);

	void Update () {
        if(ball.transform.position.z > -1829) { // -1829 is head pin position.
            transform.position = ball.transform.position + offset;
        }
	}
}
