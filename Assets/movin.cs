using UnityEngine;
using System.Collections;

public class movin : MonoBehaviour {

	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * 0.1f;


	}
}
