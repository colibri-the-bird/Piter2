using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lever1;
    public GameObject lever2;

    public GameObject target;
    public GameObject R_Platform;

    private Vector2 R1;
    private Vector2 R2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        R1 = new Vector2(lever1.transform.localPosition.x, lever1.transform.localPosition.z);
        R2 = new Vector2(lever2.transform.localPosition.x, lever2.transform.localPosition.z);

        if (R1.x > 1) R1.x = 1;
        if (R1.x < -1) R1.x = -1;
        if (R1.y > 1) R1.y = 1;
        if (R1.y < -1) R1.y = -1;
        if (R2.x > 1) R2.x = 1;
        if (R2.x < -1) R2.x = -1;
        if (R2.y > 1) R2.y = 1;
        if (R2.y < -1) R2.y = -1;

        target.transform.localPosition += new Vector3(0,0,R1.y*Time.deltaTime);
        float z = target.transform.localPosition.z;
        float y = target.transform.localPosition.y;
        if (target.transform.localPosition.z > -2) z = -2;
        if (target.transform.localPosition.z < -9) z = -9;
        target.transform.localPosition = new Vector3(0,y,z);


        R_Platform.transform.localRotation = Quaternion.Lerp(R_Platform.transform.rotation, Quaternion.Euler(0, R1.x*100, 0), Time.deltaTime);

        lever1.transform.localPosition = new Vector3(R1.x, 0, R1.y);
        lever2.transform.localPosition = new Vector3(R2.x, 0, R2.y);
    }
}