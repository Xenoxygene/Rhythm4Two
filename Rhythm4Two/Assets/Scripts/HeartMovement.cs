using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeartMovement : MonoBehaviour
{
	private float timer = 0.8f;
	private bool counting = true;

    // Start is called before the first frame update
    void Start()
    {
		transform.DOScale(1.3f, 0.2f).SetLoops(-1, LoopType.Yoyo);
	}

    // Update is called once per frame
    void Update()
    {
		if (timer <= 0)
		{
			counting = false;
			DOTween.Kill(transform);
			StartCoroutine(Pulse());
			timer = 0.8f;
			transform.localScale = new Vector3(1, 1, 1);
		}

		if(counting)
			timer -= Time.deltaTime;
	}

	IEnumerator Pulse()
	{
		yield return new WaitForSeconds (1);
		transform.DOScale(1.3f, 0.2f).SetLoops(-1, LoopType.Yoyo);
		counting = true;
	}
}
