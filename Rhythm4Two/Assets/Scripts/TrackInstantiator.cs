using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackInstantiator : MonoBehaviour
{

	public Track track;

	public Text trackName;

	[System.Serializable]
	public class Notes
	{
		public float time;
		public GameObject note;
	}

	public Notes[] notes;
	private int count = 0;


	// Start is called before the first frame update
	void Start()
    {
		System.Array.Resize(ref notes, track.markers.Length);
		trackName.text = track.name;

		StartCoroutine("spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator spawn()
	{
		yield return new WaitForSeconds(.1f);

		foreach (var item in notes)
		{
			item.time = track.markers[count];
			item.note = track.notes[count];
			count++;
		}
	}
}
