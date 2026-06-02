using UnityEngine;
using System.Collections;

public class RhythmSpawner : MonoBehaviour
{
    [Header("Note Setup")]
    public GameObject notePrefab;

    [Header("Tempo")]
    public float bpm = 90f;

    // Time between beats (calculated from BPM)
    private float beatInterval;

    [Header("Spawn Settings")]
    public float spawnY = 6f; // top of screen

    void Start()
    {
        beatInterval = 60f / bpm;

        // Start rhythm loop
        StartCoroutine(BeatLoop());
    }

    private IEnumerator SpawnNotes()
{
    // Wait 1 second
    yield return new WaitForSeconds(0f);

    // Continue with the rest of the code
    Debug.Log("Spawning notes...");
}
    IEnumerator BeatLoop()
    {
        int beatIndex = 0;

        while (true)
        {
            SpawnBeat(beatIndex);

            beatIndex++;
            yield return new WaitForSeconds(beatInterval);
        }
    }

    void SpawnBeat(int beatIndex)
    {
        // EDIT THIS ARRAY TO CONTROL NOTES
        BeatData beat = GetBeatData(beatIndex);

        if (!beat.spawn)
            return;

        foreach (float xPos in beat.xPositions)
        {
            Vector3 spawnPos = new Vector3(xPos, spawnY, 0);
            Instantiate(notePrefab, spawnPos, Quaternion.identity);
        }
    }

    // ----------------------------
    // 🎼 YOUR SONG CHART GOES HERE
    // ----------------------------
    BeatData GetBeatData(int beat)
    {
        BeatData data = new BeatData();

        // Example pattern:
        // Beat 0 → note at X = 0
        // Beat 1 → no note
        // Beat 2 → two notes

        switch (beat)
        {
            case 0:
                data.spawn = true;
                data.xPositions.Add(-2.113f);
                break;

            case 1:
                data.spawn = true;
                data.xPositions.Add(-.113f);
                data.xPositions.Add(.36f);
                data.xPositions.Add(-.586f);
                break;

            case 2:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

            case 3:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 4:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 5:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 6:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 7:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 8:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 9:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                case 10:
                data.spawn = true;
                data.xPositions.Add(1f);
                break;

                

                
        }

        return data;
    }
}

// ----------------------------
// Helper class
// ----------------------------
[System.Serializable]
public class BeatData
{
    public bool spawn = false;
    public System.Collections.Generic.List<float> xPositions = new System.Collections.Generic.List<float>();
}