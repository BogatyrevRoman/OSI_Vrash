using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float moveY = 0f; // Начальное значение перемещения по оси Y

        // Проверяем нажатие кнопок 3 и 4 для изменения перемещения по оси Y
        if (Input.GetKey(KeyCode.Alpha4)) // Если нажата кнопка 3
        {
            moveY = speed * Time.deltaTime; // Перемещение вверх
        }
        else if (Input.GetKey(KeyCode.Alpha3)) // Если нажата кнопка 4
        {
            moveY = -speed * Time.deltaTime; // Перемещение вниз
        }

        transform.Translate(0, 0, moveY); // Применяем перемещение по оси Y
    }
}
