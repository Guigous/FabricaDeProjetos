using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HudManager : MonoBehaviour
{

    public static HudManager Instance;

    public GameObject gameoverScrn;
    public Slider healthBar;
    public SceneMManager mManager;
    public float lives = 3f;

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
    /*void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    */


    // Start is called before the first frame update
    void Start()
    {

        healthBar.value = lives;
        Disable();
        Debug.Log(lives);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        
        healthBar.value--;
    }
    public void Death()
    {
        gameoverScrn.SetActive(true);
        
        
    }
    public void Disable()
    {
        
        gameoverScrn.SetActive(false);
    }
    
}
