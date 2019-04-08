using UnityEngine;

public class PlatformGenerationForBlue : MonoBehaviour
{

    // Get the prefab for the platforms
    public GameObject platformPrefab;

    // Create a vector to iterate on (iterate the Y-axis so they keep going higher)
    Vector3 spawnPosition = new Vector3();

    // Declare some variables
    public GameObject[] platformArray = new GameObject[20];
    public float levelWidth = 3f, minY = .2f, maxY = 1.5f;

    // Use this for initialization
    void Start()
    {
        // Create the initial platforms
        for (int i = 0; i < platformArray.Length; i++)
        {
            platformArray[i] = Instantiate(platformPrefab, RandomPosition(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Make the platforms gradually spawn further and further apart
        minY = Mathf.Min(minY + Random.Range(0f, 0.001f), maxY);

        // Check the existing platforms and move them if they have been passed
        for (int i = 0; i < (platformArray.Length); i++)
        {
            if (IsVisibleToCamera(platformArray[i].transform) == true)
            {
                platformArray[i].transform.position = RandomPosition();
            }
        }
    }

    // Generate a random position vector for the new platforms
    Vector3 RandomPosition()
    {
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        spawnPosition.y += Random.Range(minY, maxY);
        spawnPosition.z = 0;

        return spawnPosition;
    }

    // Check if the camera can see an object via it's trasform
    public static bool IsVisibleToCamera(Transform transform)
    {
        Vector3 visTest = Camera.main.WorldToViewportPoint(transform.position);
        return (visTest.y < 0);
    }
}