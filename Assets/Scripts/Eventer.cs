using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventor : MonoBehaviour
{
    public UnityEvent onMouseClicked; //unityevent - создает поле как на кнопкахЫ

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            onMouseClicked?.Invoke(); //вызов ивента (? означает что если пустой, то не вызывается)
        }
    }
}
