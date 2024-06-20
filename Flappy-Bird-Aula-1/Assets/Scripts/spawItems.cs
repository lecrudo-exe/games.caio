using System.Collections;
using System.Collections.Generic;
using UnityEgine;

public class SpawItems : MonoBehaviour {

    public GameObject[] spawItens;
    int random;
    public float spawtime;
    public float spawndelay;

    void Start()
    {
        invokeRepeating("spawnRandow", spawtime, spawndelay);
    }
    void SpawnRandom()
    {
        random = Random.range(0, spawItens.Length);
        Instantiante(spawItens[random],Transform.position, trasform.rotation);
    }




}
