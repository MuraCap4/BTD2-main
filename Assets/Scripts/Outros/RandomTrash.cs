using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrash : MonoBehaviour
{

    public GameObject[] lixos;
    public GameObject[] lixos1;
    public GameObject[] lixos2;
    public GameObject[] lixos3;
    public GameObject[] lixos4;
    int rdm;
    int rdm1;
    int rdm2;
    int rdm3;
    int rdm4;
  

    public void Start()
    {
        rdm  = Random.Range(0, 10);
        rdm1 = Random.Range(0, 10);
        rdm2 = Random.Range(0, 10);
        rdm3 = Random.Range(0, 10);
        rdm4 = Random.Range(0, 10);

        lixos[rdm ].SetActive(true);
        lixos1[rdm1].SetActive(true);
        lixos2[rdm2].SetActive(true);
        lixos3[rdm3].SetActive(true);
        lixos4[rdm4].SetActive(true);

       
    }

}
