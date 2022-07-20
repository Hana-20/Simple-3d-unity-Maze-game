using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject Player;
    float offset1;
    // Start is called before the first frame update
    void Start()
    {



    }
    // Update is called once per frame
    void Update()
    {
        /*var RotationVector = transform.rotation.eulerAngles;
        RotationVector.y = Player.transform.rotation.eulerAngles.y;
        RotationVector.x = 0;
        RotationVector.z = 0;
        transform.rotation = Quaternion.Euler(RotationVector);
        if (Player.transform.position.x < 0)
        {
            offset1 =offset*-1;
        }else
        {
            offset1 = offset;
        }
        transform.position = new Vector3(Player.transform.position.x+offset1, transform.position.y, Player.transform.position.z);
        // transform.rotation = new Quaternion(30,  Player.transform.rotation.y, 0, Time.deltaTime * 2.0f);
*/
        Vector3 back = Player.transform.forward;
        Vector3 position = Player.transform.position - back * 1.5f; 
        position.y = 1.4762f;
        transform.position = position;
        Vector3 r = Player.transform.position - transform.position;
        r.y = 0;
        transform.forward = r;
    }



}
