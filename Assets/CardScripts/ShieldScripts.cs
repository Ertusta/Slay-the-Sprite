using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScripts : MonoBehaviour
{
    public float ExtraShield = 10;
    public TMPro.TextMeshProUGUI ShieldText;

    public void ShieldBoost()
    {
        //kalkan artar
        if (Scene.Instance.State == 0)
        {
            MainCharacter.Instance.Shield = 15;
            ShieldText.text = ExtraShield.ToString();

            //tur atlar
            Scene.Instance.State = 1;
        }
        

    }
}
