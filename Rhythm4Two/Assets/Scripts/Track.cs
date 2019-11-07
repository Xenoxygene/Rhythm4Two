using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Track", menuName = "Track")]
public class Track : ScriptableObject
{
	public new string name;

    [FMODUnity.EventRef]
    public string FMODEvent = null;

    public float length;
	public int bpm;
	private float[] markers;

	[System.Serializable]
	public class Notes
	{
		public float marker;
		public GameObject note;
	}

	public Notes[] notes;
}
