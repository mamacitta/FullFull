using System;
using UnityEngine;
public class PlayerCollision : MonoBehaviour {
    public PlayerHP playerHp;
    public AudioSource audioSource;
    public GameObject effect;
    private void OnTriggerEnter(Collider other)
    {
        playerHp.DamageHp(1);
        var eff = Instantiate(effect);
        eff.transform.position = transform.position;
        audioSource.Play();
        Destroy(other.gameObject);
    }    
}
