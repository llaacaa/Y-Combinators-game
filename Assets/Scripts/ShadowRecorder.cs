using System.Collections.Generic;
using UnityEngine;

public class ShadowRecorder : MonoBehaviour
{
    public GameObject shadowPrefab;
    private Transform spawnPoint;
    private bool isRecording = false;
    private List<PlayerInputFrame> recordedInputs = new List<PlayerInputFrame>();
    private float recordTimer = 0f;
    public float maxRecordTime = 10f;
    private Vector3 spawnPosition;
    private Vector3 scale;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isRecording)
            {
                recordedInputs = new List<PlayerInputFrame>();
                isRecording = true;
                recordTimer = 0f;
                spawnPosition = transform.position;
                scale = transform.localScale;
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
                    jump = Input.GetKeyDown(KeyCode.Space),
                    interact = Input.GetKeyDown(KeyCode.F)
                });
            }
        }
    }

    void SpawnShadow()
    {
        GameObject shadow = Instantiate(shadowPrefab, spawnPosition, Quaternion.identity);
        shadow.transform.rotation = transform.rotation;
        ShadowPlayback playback = shadow.GetComponent<ShadowPlayback>();
        playback.LoadPlayback(recordedInputs,spawnPosition);
    }

}

[System.Serializable]
public class PlayerInputFrame
{
    public float time;
    public float horizontal;
    public bool jump;
    public bool interact;
}