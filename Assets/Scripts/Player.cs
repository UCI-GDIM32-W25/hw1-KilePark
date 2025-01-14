using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    public Sprite FaceUp;
    public Sprite FaceDown;
    public Sprite FaceLeft;
    public Sprite FaceRight;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = FaceUp;
            pos.y += _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = FaceLeft;
            pos.x -= _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().sprite = FaceDown;
            pos.y -= _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = FaceRight;
            pos.x += _speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void PlantSeed ()
    {
        
    }
}
