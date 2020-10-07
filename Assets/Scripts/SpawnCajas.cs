using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCajas : MonoBehaviour
{
    public GameObject prefabCaja;
    public int cantCajasX = 10;
    public int cantCajasZ = 10;
    public float altura = 5.0f;
    public float separacion = 2.0f;

    void Start()
    {
        for (int x = -cantCajasX / 2; x < cantCajasX / 2; ++x)
        {
            for (int z = -cantCajasZ / 2; z < cantCajasZ / 2; ++z)
            {
                Vector3 pos = new Vector3(x * separacion, altura, z * separacion);
                GameObject.Instantiate(prefabCaja, pos, Quaternion.identity);
            }
        }
    }
}
