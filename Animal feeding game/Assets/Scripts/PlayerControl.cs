using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float Xrange = 10.0f;
    public float ZrangeMax = 10.0f;
    public float ZrangeMin = 0f;

    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }

        if(transform.position.z > ZrangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZrangeMax);
        }

        if (transform.position.z < ZrangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZrangeMin);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed* Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Lanch projectile from the player
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}
