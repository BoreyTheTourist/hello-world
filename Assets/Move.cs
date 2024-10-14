using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var trans = GetComponent<RectTransform>();
        if (trans.position.y < 0 || trans.position.y > Screen.height) {
            speed = -speed;
        }
        GetComponent<RectTransform>().Translate(Vector3.up * speed);
    }
}
