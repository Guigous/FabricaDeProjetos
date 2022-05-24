using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCastTest : MonoBehaviour
{
    RaycastHit hit;
    public float maxDistance;
    bool isHiting;

    private void FixedUpdate()
    {
        isHiting = Physics.SphereCast(transform.position, transform.localScale.x / 3, Vector3.down, out hit, maxDistance);

    }

    private void OnDrawGizmos()
    {
    if (isHiting)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, Vector3.down * maxDistance);
            Gizmos.DrawWireSphere(transform.position + (Vector3.down * hit.distance), transform.localScale.x / 2);
            print(hit.collider.name);
        } else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, Vector3.down * maxDistance + new Vector3(0, -transform.localScale.x / 2, 0));
        }
    }
}
