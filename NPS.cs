using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // �������� NPC:
    int health = 5;
    // ������� NPC:
    int level = 1;
    // �������� NPC:
    float speed = 1.2f;


    void Start()
    {
        // ���������� ��������:
        health = health + level;
        print("������: " + health);
    }

    // ������������� NPC, ������� ������ ��������� ������:
    void Update()
    {
        // �������� ���������� ��� ������, ������� �������� �� ��������� �������� � ��������� � ��� ������� NPC
        Vector3 newPosition = transform.position;

        //������ ������� NPC �� ��� z �������� �������� NPC � ������� ����� �������
        newPosition.z += speed * Time.deltaTime;

        //������ ������� NPC �� ����� ��������, ������������ ����
        transform.position = newPosition;
        
    }
}