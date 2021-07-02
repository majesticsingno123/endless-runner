using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
   
    private bool isShowned = false;
   
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ToggleEndMenu(float Score)
    {
        gameObject.SetActive(true);
        scoreText.text = ((int)Score).ToString();
        isShowned = true;
    }
    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void ToMenu()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
