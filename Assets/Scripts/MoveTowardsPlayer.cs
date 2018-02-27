using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour
{
    //Цель (пункт Б)
    public Transform target;

    //Стартовая позиция (ось Z)
    private float _startPos;
    //Конечная позиция (ось Z)
    private float _endPos;

    // Скорость движения врага
    public float speed = 5;

    // Use this for initialization
    void Start()
    {
        //player = GameObject.Find("hero").transform;

        speed = Random.Range(-5, 10);
    }

    // Update is called once per frame
    void Update()
    {
       
                transform.Translate(speed * Time.deltaTime , speed * Time.deltaTime, 0); // наш метод, нам нужно движение по оси координат z 
        //Vector3 delta = player.position - transform.position;
        //delta.Normalize();
        //float moveSpeed = speed * Time.deltaTime;
        //transform.position = transform.position + (delta * moveSpeed);
        
       //Новая позиция по оси Z
	
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wallD")
        {
            transform.Translate(0, 0, 0);
        }
    }

}