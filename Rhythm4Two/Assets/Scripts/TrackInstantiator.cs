using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackInstantiator : MonoBehaviour
{
	public Track track;

	[Header("Track Info")]
	public Text trackName;

	// Start is called before the first frame update
	void Start()
    {
		trackName.text = track.name;
		StartCoroutine("spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator spawn()
	{
		yield return new WaitForSeconds(track.notes[0].marker);
		Instantiate(track.notes[0].note);

		for (int count = 1; count < track.notes.Length; count++)
		{
			yield return new WaitForSeconds(track.notes[count].marker - track.notes[count - 1].marker);
			if (track.notes[count].note != null)
				Instantiate(track.notes[count].note);
		}
	}
}
