using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineVisualizer : MonoBehaviour {

	public int detail;
	public float amplitude;
	float startPosition;

	// Use this for initialization
	void Start () {
		
		startPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		float[] info = new float[detail];

		AudioListener.GetOutputData (info, 0);
		float packagedData = 0f; 

		for (int x = 0; x < info.Length; x++) {
			packagedData = packagedData + System.Math.Abs (info [x]);
		}

		transform.position = new Vector3 (0, startPosition + packagedData * amplitude, 0);
	}
}
