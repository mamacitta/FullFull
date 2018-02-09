using UnityEngine;
public class EnemyMove : MonoBehaviour {
    public GameObject player;
    public float speed = 5.0f;
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        var diff = player.transform.position-transform.position;
        var dir = diff.normalized; //unit vector
        transform.Translate(dir*Time.deltaTime*speed);
    }
}
