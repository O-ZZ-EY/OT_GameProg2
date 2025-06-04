using UnityEngine;

public class CoinTimer : MonoBehaviour
{
    public GameObject coin;
    public float range;
    public float coinTimerInterval;
    public float currentTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn Coin", 0f, coinTimerInterval);

    }

    // Update is called once per frame
    private void Update()
    {
        coinTimerInterval = Time.deltaTime;
        if (currentTimer <= 0f)
        {
            SpawnCoin();
            currentTimer = coinTimerInterval;
          
        }
    }

    void SpawnCoin()
    {
        Vector3 position;

        position = Random.insideUnitSphere * range;
        position.z = 0f;

        Instantiate(coin, position, Quaternion.identity);
    }

}

