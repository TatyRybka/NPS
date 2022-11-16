using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // Здоровье NPC:
    int health = 5;
    // Уровень NPC:
    int level = 1;
    // Скорость NPC:
    float speed = 1.2f;


    void Start()
    {
        // Обновление здоровья:
        health = health + level;
        print("Жизней: " + health);
    }

    // Дружественный NPC, который просто двигается вперед:
    void Update()
    {
        // Создадим переменную тип данных, которая отвечает за положение обьектов и сохраняем в нее позицию NPC
        Vector3 newPosition = transform.position;

        //Меняем позицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;

        //Меняем позицию NPC на новое значение, рассчитанное выше
        transform.position = newPosition;
        
    }
}