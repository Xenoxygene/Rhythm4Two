using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
	public enum Type
	{
		UpLeft,
		UpRight,
		ShapeDecrease,
		ShapeIncrease,
		ShapeV,
		ShapeA,
		DownLeft,
		DownRight
	}


	[SerializeField]
	private Type type;
}
