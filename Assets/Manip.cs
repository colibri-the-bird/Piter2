using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manip : MonoBehaviour
{
    public Transform Bedro;
    public Transform Koleno;
    public Transform Stup;

    private float angle_B;
    private float angle_A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var a = Vector3.Distance(Bedro.position, Koleno.position);
        var dist = Vector3.Distance(Bedro.position, Stup.position);
        var d2 = Vector2.Distance(new Vector2(Bedro.position.x, Bedro.position.y),
            new Vector2(Stup.position.x, Stup.position.y));
        var d1 = Stup.position.y - Bedro.position.y;

        angle_B = (Mathf.Acos((a*a*2 - dist*dist)/(2*a*a)) - Mathf.PI)*(Mathf.Abs(Koleno.localPosition.x + Stup.position.x)/ (Koleno.localPosition.x + Stup.position.x));
        Koleno.localRotation = Quaternion.Euler(0, 0, 180 * angle_B / Mathf.PI);
        angle_A = Mathf.Abs(Koleno.localPosition.x + Stup.position.x) / (Koleno.localPosition.x + Stup.position.x) * (((Mathf.PI - Mathf.Abs(angle_B))/2 + Mathf.Acos((dist*dist + d2*d2 - d1*d1)/(2*dist*d2))) - Mathf.PI/2 + Mathf.PI/3);
        Bedro.localRotation = Quaternion.Euler(0,0,180*angle_A/Mathf.PI);
        
    }
}
