using System.Collections.Generic;
using UnityEngine;

public class ShadowRecorder : MonoBehaviour
{
    public GameObject shadowPrefab;
    public Transform spawnPoint;
    private bool isRecording = false;
    private List<PlayerInputFrame> recordedInputs = new List<PlayerInputFrame>();
    private float recordTimer = 0f;
    public float maxRecordTime = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isRecording)
            {
                recordedInputs.Clear();
                isRecording = true;
                recordTimer = 0f;
            }
            else
            {
                isRecording = false;
                SpawnShadow();
            }
        }

        if (isRecording)
        {
            recordTimer += Time.deltaTime;
            if (recordTimer > maxRecordTime)
            {
                isRecording = false;
                SpawnShadow();
            }
            else
            {
                recordedInputs.Add(new PlayerInputFrame
                {
                    time = Time.time,
                    horizontal = Input.GetAxisRaw("Horizontal"),
                    jump = Input.GetKeyDown(KeyCode.Space)
                });
            }
        }
    }

    void SpawnShadow()
    {
        GameObject shadow = Instantiate(shadowPrefab, spawnPoint.position, Quaternion.identity);
        ShadowPlayback playback = shadow.GetComponent<ShadowPlayback>();
        playback.LoadPlayback(recordedInputs);
    }
}

[System.Serializable]
public class PlayerInputFrame
{
    public float time;
    public float horizontal;
    public bool jump;
}