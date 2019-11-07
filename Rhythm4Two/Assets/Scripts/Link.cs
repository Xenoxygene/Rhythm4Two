using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
	private LineRenderer link;

	private Transform leftSide, middle, rightSide;
	private Vector3 leftSidePos, middlePos, rightSidePos;

	public float speed = 1f;
	private float step;

    // Start is called before the first frame update
    void Start()
    {
		link = GetComponent<LineRenderer>();

		leftSide = transform.GetChild(0);
		leftSidePos = leftSide.position;

		middle = transform.GetChild(1);
		middlePos = middle.position;

		rightSide = transform.GetChild(2);
		rightSidePos = rightSide.position;


	}

	// Update is called once per frame
	void Update()
    {
		step = speed * Time.deltaTime;

		link.SetPosition(1, leftSide.position);
		link.SetPosition(2, middle.position);
		link.SetPosition(3, rightSide.position);

		if (Input.GetKey(KeyCode.W))
			leftSide.position = Vector3.MoveTowards(leftSide.position, leftSidePos + new Vector3(0, 5, 0), step);
		else if (Input.GetKey(KeyCode.S))
			leftSide.position = Vector3.MoveTowards(leftSide.position, leftSidePos + new Vector3(0, -5, 0), step);
		else
			leftSide.position = Vector3.MoveTowards(leftSide.position, leftSidePos, step);

		if (Input.GetKey(KeyCode.UpArrow))
			rightSide.position = Vector3.MoveTowards(rightSide.position, rightSidePos + new Vector3(0, 5, 0), step);
		else if (Input.GetKey(KeyCode.DownArrow))
			rightSide.position = Vector3.MoveTowards(rightSide.position, rightSidePos + new Vector3(0, -5, 0), step);
		else
			rightSide.position = Vector3.MoveTowards(rightSide.position, rightSidePos, step);
	}
}
