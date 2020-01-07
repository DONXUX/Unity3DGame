using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int timer = 0;
    public GameObject capsule;
    public float speed = 3.0f;
    void Start()
    {
        Debug.Log("초기화가 이루어졌습니다.");
        capsule = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        Debug.Log(timer + "번째 업데이트");
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
