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
    public Tilemap tilemap; // 타일맵 컴포넌트
    [SerializeField] Grid m_Grid;
    public TileBase soil;

    private void Start()
    {
        // 타일맵 내의 셀 좌표들에 대해서 타일이 있다면 딕셔너리에 초기 정보를 추가한다.
        foreach (Vector3Int pos in tilemap.cellBounds.allPositionsWithin)
        {
            // 해당 좌표에 타일이 없으면 넘어간다.
            if (!tilemap.HasTile(pos)) continue;
            // 해당 좌표의 타일을 얻는다.
            var tile = tilemap.GetTile<TileBase>(pos);
            // 정보 초기화
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
