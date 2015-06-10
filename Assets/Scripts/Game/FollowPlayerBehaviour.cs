using UnityEngine;
using System.Collections;

public class FollowPlayerBehaviour : MonoBehaviour {

  public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {
		var pos = transform.position;
		pos.x = player.transform.position.x;
		pos.z = player.transform.position.z;
		transform.position = pos;
	}
}
