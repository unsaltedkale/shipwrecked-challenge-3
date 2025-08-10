using UnityEngine;

public class PlayerCreator : MonoBehaviour
{

    public string[] keyPairings;

    public GameObject playerPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("hello");

        for (int i = 0; i < keyPairings.Length; i++)
        {
            print("hello!!");
            GameObject clone = Instantiate(playerPrefab, transform.position, transform.rotation);

            PlayerMovement cloneScript = clone.GetComponent<PlayerMovement>();

            cloneScript.leftKey = keyPairings[i];
            cloneScript.rightKey = keyPairings[i+1];

            cloneScript.namePlate.text = cloneScript.leftKey + "/" + cloneScript.rightKey

            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
