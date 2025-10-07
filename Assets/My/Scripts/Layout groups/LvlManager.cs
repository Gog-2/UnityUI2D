using System;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
    public GameObject prefab, ListLvl;
    public int counter = 0;
    [SerializeField] private LvlCell _prefab;
    private void Start()
    {
        int OpenLevelCounter = UnityEngine.Random.Range(0, 10);
        for (int i = 0; i < 10; i++)
        {
            counter++;
            LvlCell cell = Instantiate(_prefab, ListLvl.transform);
            cell.Init(counter, i > OpenLevelCounter);
        }
    }
}
