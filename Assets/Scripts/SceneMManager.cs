using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneMManager : MonoBehaviour
{

    public string sceneStart;
    public static SceneMManager Instance;
    public Button quit;
    public Button restart;
    public Button startGame;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    


    public void Retry()
    {
        HudManager.Instance.healthBar.value = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HudManager.Instance.Disable();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(sceneStart);
        
    }

    







    // Start is called before the first frame update
    void Start()
    {
        quit.GetComponent<SceneMManager>();
        restart.GetComponent<SceneMManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
