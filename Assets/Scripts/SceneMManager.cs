using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMManager : MonoBehaviour
{

    public string sceneStart;
    public static SceneMManager Instance;
    public Button quit;
    public Button restart;

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
        SceneManager.LoadScene("TestePLAYGROUND");
        Debug.Log("Cai Aqui");
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
