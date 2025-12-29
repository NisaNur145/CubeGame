using System.Collections;
using UnityEngine;

public class Engelspawner : MonoBehaviour
{
    public float spawnAraligi=3f;
    public GameObject Obje;
    public float yokolmasuresi=3f;
    public void Start()
    {
        StartCoroutine(ObjeSpawn());
    }
    IEnumerator ObjeSpawn()
    {
        while (true)
        {
            SpawnObje();
            yield return new WaitForSeconds(spawnAraligi);
        }
        
    }
    
    void SpawnObje()
    {
        GameObject Yeniobje=Instantiate(Obje,transform.position,Quaternion.identity);
        Destroy(Yeniobje,yokolmasuresi);
    }

}
