using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilidadDeCasteo : MonoBehaviour
{
    public void Cast (Ray ray, float range)
    {
        ray.origin = transform.position;
        ray.direction = transform.forward;
        Physics.Raycast(ray, range);

        Debug.DrawRay(ray.origin, ray.direction * range, Color.green, 5);
    }
}
