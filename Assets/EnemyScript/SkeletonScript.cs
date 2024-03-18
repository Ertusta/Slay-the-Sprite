using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    public float Health = 30;    
      
    public float Damage = 10;

    public TMPro.TextMeshProUGUI HealthText;

    public Animator Animator;
    
    public void TakingDamage()
    {
        

        if(MainCharacter.Instance.state==0)
        {
            Health-=MainCharacter.Instance.Damage;
            HealthText.text = Health.ToString();

            MainCharacter.Instance.state=2;

            if (Health < 1)
            {
                gameObject.SetActive(false);
                Scene.Instance.EnemyNumber -= 1;
            }


        }
        if (MainCharacter.Instance.state == 1)
        {

            //hasar alma
            Health -=MainCharacter.Instance.Damage+ MainCharacter.Instance.ExtraDamage;
            HealthText.text = Health.ToString();

            //tur atlama
            MainCharacter.Instance.state = 2;

            //�lme
            if (Health < 1)
            {
                gameObject.SetActive(false);
                Scene.Instance.EnemyNumber -= 1;
            }

            
        }
    }
}
