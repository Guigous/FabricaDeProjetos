using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp34 : MonoBehaviour
{
    public GameObject objtoTP;
    public GameObject objtoTP2;
    public GameObject objtoTP3;
    public GameObject objtoTP4;
    public GameObject objtoTP5;
    public GameObject objtoTP6;
    public GameObject objtoTP7;
    public GameObject objtoTP8;
    public GameObject objtoTP9;
    public GameObject objtoTP10;
    public GameObject objtoTP11;
    public GameObject objtoTP12;
    public Transform tpLoc;

    private void Start()
    {
        StartCoroutine(EsperaSegundos());
    }
    private IEnumerator EsperaSegundos()
    {
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP2.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP3.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP4.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP5.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP6.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP7.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP8.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP9.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP10.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP11.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
        objtoTP12.transform.position = tpLoc.transform.position;
        yield return new WaitForSeconds(1f); //número que vc quer em segundos
    }

    /* private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Spheres")
         {
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP2.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP3.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP4.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP5.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP6.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP7.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP8.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP9.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP10.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos
             objtoTP11.transform.position = tpLoc.transform.position;
             yield return new WaitForSeconds(1f); //número que vc quer em segundos 

         }
     }*/
}
