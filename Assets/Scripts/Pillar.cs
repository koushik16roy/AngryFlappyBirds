using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public int killPositionX = -10;
    Transform selfTransform;
    // Start is called before the first frame update
    void Start()
    {
        selfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.gameOver)
            selfTransform.position -= new Vector3(moveSpeed, 0);
        if(selfTransform.position.x < killPositionX)
        {
            Destroy(gameObject,3f);
        }
    }
}
