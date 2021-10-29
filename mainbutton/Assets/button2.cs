using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }
}
