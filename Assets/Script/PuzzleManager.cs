using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private List<NoteSlot> slotPrefabs;
    [SerializeField] private Transform slotParent, pieceParent;
    [SerializeField] private NotePiece piecePrefab;
    private void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        var randomSet = slotPrefabs.OrderBy(s => Random.value).Take(3).ToList();

        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], slotParent.GetChild(i).position, Quaternion.identity);

            var spawnedPiece = Instantiate(piecePrefab, pieceParent.GetChild(i).position, Quaternion.identity);
            spawnedPiece.Init(spawnedSlot);
        }
    }
}
