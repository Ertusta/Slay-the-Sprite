using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float Health = 100;
    public float Shield;
    public float State;
    public float Level;
    public float Damage=10;
    public float ExtraDamage = 0;

    

    public float state=0;

    



    //Di�er objeler taraf�ndan eri�mesi i�in 1
    public static MainCharacter Instance;


    //animator
    public Animator Animator;
    

    void Start()
    {
        
        //Di�er objeler taraf�ndan eri�mesi i�in 2
        Instance = this;
    }

    //sald�r� animasyonu
   public void Animation()
    {
        Animator.SetFloat("State", 1);
        Invoke("Stop", 1);
        state=3;

        
        
    }

    //�dle a d�n��
    private void Stop() 
    {

        Animator.SetFloat("State", 0);
        
        
    }

    //�l�m
    private void Update()
    {
        if (Health < 1)
        {
            gameObject.SetActive(false);
            
        }
    }
    
    
       
    

}
