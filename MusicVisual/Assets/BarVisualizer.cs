using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarVisualizer : MonoBehaviour {

	public int detail;
	public float amplitude;
	Vector3 startScale;

	// Use this for initialization
	void Start () {

		startScale = transform.localScale;
	}

	// Update is called once per frame
	void Update () {

		float[] info = new float[detail];

		AudioListener.GetOutputData (info, 0);
		float packagedData = 0f; 

		for (int x = 0; x < info.Length; x++) {
			packagedData = packagedData + System.Math.Abs (info [x]);
		}

		transform.localScale = startScale + new Vector3 (0, packagedData * amplitude, 0);
	}
}
