using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private GameObject[] _main;
	public GameObject _heart1, _heart2;
	public GameObject _lights;
	public GameObject _camera;
	public GameObject _link;
	public GameObject _postProcess;

    // Start is called before the first frame update
    void Start()
    {
		_main = new GameObject[] { _heart1, _heart2, _lights, _camera, _link, _postProcess };
		foreach (GameObject item in _main)
		{
			Instantiate(item);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
