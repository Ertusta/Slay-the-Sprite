using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    public float ExtraHeal = 25;
    public TMPro.TextMeshProUGUI HealthText;

    public void HealBoost()
    {
        if (Scene.Instance.State == 0)
        {//can artar
            MainCharacter.Instance.Health += ExtraHeal;

            //iyileþme maksimun caný geçemez
            if (MainCharacter.Instance.Health > 100)
            {
                MainCharacter.Instance.Health = 100;
            }

            //can deðiþkenini günceller
            HealthText.text = MainCharacter.Instance.Health.ToString();
            //tur atlar
            Scene.Instance.State = 1;
        }
        
    }


}
