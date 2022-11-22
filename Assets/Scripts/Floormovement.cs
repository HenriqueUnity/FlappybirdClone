using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floormovement : MonoBehaviour
{
    [SerializeField] private float multiplicator;
    private float timer;
    [SerializeField] private float bounceTime;
    void Update()
    {

        transform.position += new Vector3 (1 * multiplicator * Time.deltaTime, 0, 0);
        timer += Time.deltaTime;
        if(timer >= bounceTime)
        {
            multiplicator *= -1;
            timer = 0;
        }
    }
    
}
