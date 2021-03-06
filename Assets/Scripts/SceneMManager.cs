using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneMManager : MonoBehaviour
{

    public string proximaFase;
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
        HudManager.Instance.healthBar.value = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HudManager.Instance.Disable();
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ProximaFase()
    {
        SceneManager.LoadScene(proximaFase);
        
    }

    







    // Start is called before the first frame update
    void Start()
    {
        quit.GetComponent<SceneMManager>();
        restart.GetComponent<SceneMManager>();
        
        
        
        
    } 

    
    
}
