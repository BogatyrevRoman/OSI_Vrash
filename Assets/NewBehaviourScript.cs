using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float moveY = 0f; // ��������� �������� ����������� �� ��� Y

        // ��������� ������� ������ 3 � 4 ��� ��������� ����������� �� ��� Y
        if (Input.GetKey(KeyCode.Alpha4)) // ���� ������ ������ 3
        {
            moveY = speed * Time.deltaTime; // ����������� �����
        }
        else if (Input.GetKey(KeyCode.Alpha3)) // ���� ������ ������ 4
        {
            moveY = -speed * Time.deltaTime; // ����������� ����
        }

        transform.Translate(0, 0, moveY); // ��������� ����������� �� ��� Y
    }
}
