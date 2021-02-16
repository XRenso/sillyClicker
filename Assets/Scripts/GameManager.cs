using System.Threading;
using System.Globalization;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;

public class GameManager : MonoBehaviour
{
 public Text GoldDisplay; 

 [HideInInspector] // спрятать в иерархие
 public int gold = 0;
 [Header ("Gold")] // выделение в  инспекторе отдельной группой
 public int goldPerClick;
 public int maxGoldPerClick;
 public int minGoldPerClick;

 public float startTime;
 private float time;

 private void Start() {
     time = startTime;// выставляем время в самом начале котрое соотвествует задержке
 }
private void Update() {
    GoldDisplay.text = "Gold:" + gold; //отоброжение золота на экране
    if(time <= 0)
    {
        time = startTime;  // выставляем определённое время когда оно дошло до 0
        ChangeGold();  // вызываем метод голды
    }
    else
    {
        time -= Time.deltaTime; // отнимаем от времени определённый кусок милисекунд
    }
}

public void ChangeGold() 
{
    goldPerClick =  Random.Range(minGoldPerClick, maxGoldPerClick); //меняем голду с помощью метода рандома сначало минимальный потом максимальный 
   
}


 }
