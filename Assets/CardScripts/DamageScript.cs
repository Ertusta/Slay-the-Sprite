using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float ExtraDamage = 10;



    //fonksiyon çalýþtýðýnda ekstra hasar ekler
    public void DamageBoost()
    {   //damage artar
        if (Scene.Instance.State == 0)
        {
            MainCharacter.Instance.ExtraDamage = ExtraDamage;

            //tur atlar
            Scene.Instance.State = 1; 
        }
        
    }
    


}
