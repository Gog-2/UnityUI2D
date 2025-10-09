using System;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
    public GameObject prefab, ListLvl;
    private int _counter = 0;
    [SerializeField] private LvlCell _prefab;
    [Header("Lvl Settings")]
    public int LvlLeght = 10;
    [SerializeField][Range(1, 10)] private int OpenLvl;
    private void Start()
    {
        for (int i = 1; i <= LvlLeght; i++)
        {
            _counter++;
            LvlCell cell = Instantiate(_prefab, ListLvl.transform);
            cell.Init( _counter, i > OpenLvl);
        }
    }
}
