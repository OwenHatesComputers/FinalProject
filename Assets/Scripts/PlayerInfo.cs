using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInfo : MonoBehaviour{

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public int honey = 0;
    public int honeyStartOfLevel = 0;

    void GainHoney() {
        honey++;
    }
    void SetHoney() {
        honey = honeyStartOfLevel;
    }

    void EndOFLevelHoney() {
        honeyStartOfLevel = honey;
    }


}
