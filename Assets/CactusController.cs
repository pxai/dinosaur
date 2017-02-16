using UnityEngine;
using System.Collections;

public class CactusController : MonoBehaviour {
	public GameObject cactus;
	private float cactusPerSecond = 0.5f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float limit = cactusPerSecond * Time.deltaTime;
		if (Random.value < limit) {
			spawnCloud ();
		}
	}
	
	private void spawnCloud() {
		Random random = new Random ();
		GameObject freshCactus = Instantiate(cactus, transform.position, Quaternion.identity) as GameObject;
		float scale = Random.Range (2,4);
		freshCactus.transform.localScale = new Vector3 (scale, scale, 0);
		freshCactus.transform.position = new Vector3 (25f,1f);
		freshCactus.GetComponent<Rigidbody2D>().velocity = Vector3.left * 5;
		
	}
}
