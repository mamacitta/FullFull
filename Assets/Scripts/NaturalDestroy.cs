using UnityEngine;
public class NaturalDestroy : MonoBehaviour {
    public float destroyTime = 5.0f;
    public float lastPlayTime;
    private void Start()
    {
        lastPlayTime = Time.time;
    }
    void Update()
    {
        if (Time.time - lastPlayTime > destroyTime)
        {
            Destroy(gameObject);
        }
    }
}
