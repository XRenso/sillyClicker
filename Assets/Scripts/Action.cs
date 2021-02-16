using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameManager mg;//указываем наш гейммэнеджер
    public void Click()
    {
        mg.gold += mg.goldPerClick; // добавить золото во время клика
    }


}
