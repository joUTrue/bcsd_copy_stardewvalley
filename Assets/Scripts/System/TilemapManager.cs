using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;


public class CustomData
{
    bool objectOnTile;
    int objectCount;
}


public class TilemapManager : MonoBehaviour
{
    public Dictionary<Vector3Int, CustomData> dataOnTiles;
    public Tilemap tilemap; // Ÿ�ϸ� ������Ʈ
    [SerializeField] Grid m_Grid;
    public TileBase soil;

    private void Start()
    {
        // Ÿ�ϸ� ���� �� ��ǥ�鿡 ���ؼ� Ÿ���� �ִٸ� ��ųʸ��� �ʱ� ������ �߰��Ѵ�.
        foreach (Vector3Int pos in tilemap.cellBounds.allPositionsWithin)
        {
            // �ش� ��ǥ�� Ÿ���� ������ �Ѿ��.
            if (!tilemap.HasTile(pos)) continue;
            // �ش� ��ǥ�� Ÿ���� ��´�.
            var tile = tilemap.GetTile<TileBase>(pos);
            // ���� �ʱ�ȭ
            dataOnTiles[pos] = new CustomData();
        }
    }

    private void Awake()
    {
        //tilemap = GetComponent<Tilemap>();
        m_Grid = GetComponent<Grid>();
    }

    public void GetTile(Vector3 vector3)
    {
        Vector3Int _vec = Vector3Int.FloorToInt(new Vector3(vector3.x,vector3.y-30.5f,vector3.z));
        tilemap.SetTile(_vec, soil);
        //Vector3Int gridPos = m_Grid.WorldToCell(vector3);
        //return tilemap.GetTile(gridPos);
    }
}
