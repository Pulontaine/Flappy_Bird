using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable] //позволяет отображать элементы этого класса в инспекторе. Например, если создаем в другом скрипте переменную типа этого класса,
//то можно создавать сериализованные поля с объектами этого класса.
public class Medal{
    public Sprite MedalSprite;
    public int ScoreNeed;

}
