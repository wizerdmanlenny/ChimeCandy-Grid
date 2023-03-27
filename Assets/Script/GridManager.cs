using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private int width, height;//camera pov field

    [SerializeField] private Tile tilePrefabs;//variable for tile holder

    [SerializeField] private Transform cam;//variable for camera
    

    private Dictionary<Vector2, Tile> tiles;//gets tile x and y
    private void Start()//activate on start
=======
    [SerializeField] private int width, height;//x and y variables for graph

    [SerializeField] private Tile tilePrefabs; //tile object

    [SerializeField] private Transform cam; //camera variable

    private Dictionary<Vector2, Tile> tiles; //tile dictionary
    private void Start()
>>>>>>> e6bbdfc4d74d89c9b9d6d63872fac189e12f6cea
    {
        GenerateGrid();
    }
    void GenerateGrid()//build the grid
    {
        tiles = new Dictionary<Vector2, Tile>();//initialize tiles
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {//create a tile grid with x width and y height
                var spawnedTile = Instantiate(tilePrefabs, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);//adds checkard pattern

                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        cam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);//set camera view
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if(tiles.TryGetValue(pos, out var tile))
        {
            return tile;
        }

        return null;
    }
}
