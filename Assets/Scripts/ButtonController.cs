using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public AudioSource audioSource; // Sound file
    public GameObject hpPanel;
    public Text addNumberButtonText; // 누르면 숫자가 증가하는 버튼의 text
    public void OpenMainScene()
    {
        SceneManager.LoadScene("FullFull");
    }
    public void StopMainScene()
    {
        SceneManager.LoadScene("Splash");
    }
    public void PlaySound()
    {
        audioSource.Play();
    }
    public void ToggleHpPanel()
    {
        hpPanel.SetActive(hpPanel.activeSelf == false);   
    }
    public void AddNumber()
    {
        var addNumber = PlayerPrefs.GetInt("ADD_NUMBER", 1);
        addNumberButtonText.text = (addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);
        PlayerPrefs.Save();
        
    }
}
