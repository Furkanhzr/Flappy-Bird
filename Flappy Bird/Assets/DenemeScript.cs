using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeScript : MonoBehaviour
{
    [SerializeField] private float jumpSpeed = 3f; //Unity'den dolayı float değerlerin yanına 3f eklemek gerekiyor.

    //oyun başlamadan önce çalışan bir fonksiyon. 1 kere çalışır
    private void Awake()
    {
    }

    //oyun başlarken çalışır. 1 kere çalışır.
    void Start()
    {
        Debug.Log("Basladi");
    }

    //her frame başında çalışır. örn: pc eğer 30fps alıyor ise 30 kere çalışıyor demektir.
    void Update()
    {
        Debug.Log("test");
    }

    //update'i fixler.
    private void FixedUpdate()
    {
        
    }

    //genellikle kameralar üzerinden kullanılır geç çalışan update fonksiyondur.
    private void LateUpdate()
    {

    }
}
