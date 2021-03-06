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
    public float lives = 3;

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
    

    // Start is called before the first frame update
    void Start()
    {

        healthBar.value = lives;


    }

    

    public void Damage()
    {
        
        healthBar.value--;
    }
    public void Death()
    {
        gameoverScrn.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

    }
    public void Disable()
    {
        
        gameoverScrn.SetActive(false);
    }
    
}
