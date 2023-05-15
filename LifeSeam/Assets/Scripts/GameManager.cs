using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject brebis;
    [SerializeField] private GameObject lion;
    [SerializeField] private GameObject vache;
    [SerializeField] private GameObject loup;
    //definition d'une variable publique protegee en ecriture 
    //public GameObject m_brebis { get; private set; }

    void Start()
    {
        Vector3 pos = new Vector3(10, 0.2f, 10);
        Instantiate(brebis, pos, brebis.transform.rotation);
         pos = new Vector3(-5, 0.5f, 15);
        Instantiate(lion, pos, lion.transform.rotation);
         pos = new Vector3(0, 0.25f, 0);
        Instantiate(vache, pos, vache.transform.rotation); 
         pos = new Vector3(-8, 0.137f, 5);
        Instantiate(loup, pos, loup.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
