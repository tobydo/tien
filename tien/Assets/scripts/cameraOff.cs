﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraOff : MonoBehaviour
{
    public Camera one;
    public Camera two;
    // Start is called before the first frame update
    void TurnOff(){
        one.enabled = false;
        two.enabled = true;

    }
}
