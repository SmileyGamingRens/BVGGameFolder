using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateRCop : MonoBehaviour
{
    [SerializeField] float speedXRCop;
    [SerializeField] float speedYRCop;
    [SerializeField] float speedZRCop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * speedXRCop * Time.deltaTime, 360 * speedYRCop * Time.deltaTime, 360 * speedZRCop * Time.deltaTime);
    }
}
