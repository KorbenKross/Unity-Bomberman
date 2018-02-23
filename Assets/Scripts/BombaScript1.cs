using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaScript1 : MonoBehaviour {

    // Как долго существует лазер
    public float lifetime = 2.0f;

    // Как много наносит урона лазер при соприкосновении с врагами
    public int damage = 1;

    // Use this for initialization
    void Start()
    {
        // Уничтожение лазера по окончанию таймера
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime);
    }
}
