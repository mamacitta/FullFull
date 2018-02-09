using System.Linq;
using UnityEngine;

public class Destroy : MonoBehaviour {
    private void DestroyAllChildren()
    {
        foreach (Transform t in transform.Cast<Transform>().ToArray())
            DestroyImmediate(t.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
