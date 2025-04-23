using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float pipSpeed = 3f;
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        transform.position += Vector3.left * pipSpeed * Time.deltaTime; //fix update'teki gibi sorun çıkmaması için deltaTime kullanıyoruz o yüzden bilgisayarlar arasında sorun çıkmıyor.
    }
}
