using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float offset;
    public GameObject Bullet;
    public Transform shortPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Update is called once per frame
    void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        if (timeBtwShots < 0)
        { 
       if(Input.GetMouseButton(0)) 
        {
            Instantiate(Bullet, shortPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
        }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
