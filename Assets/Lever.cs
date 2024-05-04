using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lever1;
    public GameObject lever2;

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

        print(R1 + "_" + R2);

        lever1.transform.localPosition = new Vector3(R1.x, 0, R1.y);
        lever2.transform.localPosition = new Vector3(R2.x, 0, R2.y);
    }
}