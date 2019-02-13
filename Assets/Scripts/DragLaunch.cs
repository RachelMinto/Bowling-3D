using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(BowlingBall))]
public class DragLaunch : MonoBehaviour {
    private BowlingBall ball;
    private DateTime dragStartTime;
    private Vector3 dragStartPosition;

	void Start () {
        ball = GetComponent<BowlingBall>();
	}

    public void DragStart() {
        dragStartTime = CurrentTime();
        dragStartPosition = CurrentPosition();
    }

    public void DragEnd() {
        Vector3 differenceInPosition = CurrentPosition() - dragStartPosition;
        float speedOfLaunch = (float)(CurrentTime() - dragStartTime).TotalMilliseconds;
        Vector3 launchVelocity = new Vector3(-differenceInPosition.x, 0, -speedOfLaunch);
        launchVelocity.z = -speedOfLaunch;ball.Launch(launchVelocity);
    }

    private DateTime CurrentTime() {
        return DateTime.Now;
    }

    private Vector3 CurrentPosition() {
        return Input.mousePosition;
    }
}
