using UnityEngine;

public class playerMove : MonoBehaviour {
    public float speed = 5.0f;
	void Update () {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(dx * Time.deltaTime * speed, 0, dz * Time.deltaTime * speed));
	}
}

