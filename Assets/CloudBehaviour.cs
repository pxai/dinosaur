using UnityEngine;
using System.Collections;

public class CloudBehaviour : MonoBehaviour {

	public GameObject cloud;
	private float cloudsPerSecond = 0.7f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float limit = cloudsPerSecond * Time.deltaTime;
		if (Random.value < limit) {
			spawnCloud ();
		}
	}

	private void spawnCloud() {
		GameObject freshCloud = Instantiate(cloud, transform.position, Quaternion.identity) as GameObject;
		float scale = Random.Range (2,7);
		freshCloud.transform.localScale = new Vector3 (scale, scale, 0);
		freshCloud.transform.position = new Vector3 (25f,Random.Range(3,10f));
		freshCloud.rigidbody2D.velocity = Vector3.left * (scale + 5);

	}
}
