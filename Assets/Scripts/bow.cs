using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    public GameObject arrow;
    public float arrowForce;
    public Transform shotPoint;




    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousePos - bowPos;
        transform.right = dir;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();

        }

    }

    void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * arrowForce;
    }

}