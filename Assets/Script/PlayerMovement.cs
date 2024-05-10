using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int  bawangMerah =  4;
    int  bawangPutih = 10;
    float garam   = 0.5f;
    float gula = 0.2f;

    
    void Start()
    {
       Debug.Log("Jumlah Bawang Merah = " + bawangMerah);
       Debug.Log("Jumlah Bawang Putih = " + bawangPutih);
       Debug.Log("Jumlah Garam = " + garam + "gram");
       Debug.Log("Jumlah Gula = " + gula + "gram");
    }

    
    void Update()
    {
        
    }


}
