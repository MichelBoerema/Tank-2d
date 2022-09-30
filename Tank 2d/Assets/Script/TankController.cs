using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    

    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform Firepoint;
    [SerializeField]
    GameObject BulletFire;
    public float felocity = 10f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical")* Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
           GameObject b = Instantiate(BulletFire, Firepoint.position, Firepoint.rotation);
            b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * felocity ,ForceMode2D.Impulse);           
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            felocity += 2;
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            felocity -= 2;
        }
            

    }
}
