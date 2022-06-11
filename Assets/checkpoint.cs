using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject Player;
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Teleport();
            HudManager.Instance.Damage();
            
        }
    }
    public void Teleport()
    {
        Player.transform.position = respawnPoint.transform.position;
        Debug.Log("TPRealisado");
        
    }
}
