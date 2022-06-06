using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    private MeshRenderer mr;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneMManager.Instance.ProximaFase();
    }
}
