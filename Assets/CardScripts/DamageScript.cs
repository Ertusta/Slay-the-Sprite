using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float ExtraDamage = 10;



    //fonksiyon �al��t���nda ekstra hasar ekler
    public void DamageBoost()
    {   //damage artar
        if (MainCharacter.Instance.state == 0)
        {
            MainCharacter.Instance.ExtraDamage = ExtraDamage;

            //tur atlar
            MainCharacter.Instance.state = 1; 
        }
        
    }
    


}
