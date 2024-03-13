using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{

    public float State = 0;
    public float EnemyNumber = 0;
    public bool Stop=true;

    public static Scene Instance;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public Animator Animator1;
    public Animator Animator2;

    public TMPro.TextMeshProUGUI HealthText;

    //dýþardan eriþmek içim
    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        //ilk iskelet hareket eder
        if (State==3 &&Stop)
        {
            Animator1.SetFloat("State", 1);
            Invoke("SecondSkeleton",1);
            Stop=false;
            
        }


    }



    //ikinci iskelet hareket eder
    private void SecondSkeleton()
    {
        Animator1.SetFloat("State", 0);
        Animator2.SetFloat("State", 1);
        Invoke("SecondSkeletonStop", 1);
        

    }

    //hasar verilir
    void SecondSkeletonStop()
    {
        Animator2.SetFloat("State",0 );
        State = 0;
        Stop= true;
        MainCharacter.Instance.Health -= 10*EnemyNumber;
        HealthText.text = MainCharacter.Instance.Health.ToString();

}



}
