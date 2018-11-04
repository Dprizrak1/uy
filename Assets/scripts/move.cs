using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    
    [Range(1,50)] // создаём ползунок и указываем его диапозон
    public int speed; // создаём переменную типа int к которой будет привязан ползунок

    void FixedUpdate ()
    { //FixedUpdate вызывается с частотой фиксированных кадров (указываются в настройках проекта)
        float move = Input.GetAxisRaw("Horizontal") * (float)speed * Time.deltaTime; //отдельно рассчитываем расстояяние на которое будет перемещён гг
        transform.Translate(move, 0, 0); //функция Translate перемещает объект в направление и на расстояние от заданных координат x, y и z соответственно 
        Debug.Log("DeltaTime: "+Time.deltaTime);
	}
}
