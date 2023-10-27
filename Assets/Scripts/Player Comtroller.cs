using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComtroller : MonoBehaviour
{
    public GameObject Player;
    public float Speed = 2.0f;
    // Update is called once per frame
    void Update()
    {



        //Перемещаем наш объект на S расстояние по оси x.
        if (Input.GetKey(KeyCode.W))
        {
            Player.transform.Translate(0, 0, Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.transform.Translate(0, 0, -Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
    }
}