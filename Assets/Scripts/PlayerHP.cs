using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {
    [SerializeField]
    private int hp=100;
    public Text hpText;
    public float healingTime = 5.0f;
    public float lastPlayerTime;
    public void HealHp(int amount)
    {
        hp += amount;
        UpdateHp();
    }
    public void DamageHp(int amount)
    {
        hp -= amount;
        UpdateHp();
    }
    private void UpdateHp()
    {
        hpText.text = hp.ToString();
    }
    private void Start()
    {
        //lastPlayerTime = Time.time;
    }
    private void Update()
    {
        hpText.text = hp.ToString();
        if (Time.time - lastPlayerTime > healingTime && hp < 100)
        {
            HealHp(1);
            lastPlayerTime = Time.time;
        }
        if (hp==0)
        {
            Time.timeScale = 0;
        }
    }
}