using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public int jumpForce = 6;
    private AudioSource _audioSource;
    private int _score;
    private UIManager _uiManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        if(_audioSource==null)
        {
            Debug.LogError("The Audio Source is NUll");
        }
        _audioSource.Play();    
    }

    //Make the bird jump
    public void Jump()
    {
        rigidbody.velocity = new Vector2(0, jumpForce);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "score")
        {
            GameManager.Instance.ScoreIncrement();
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "kill")
        {
            GameManager.Instance.GameOver();
        }
        _audioSource.Stop();
    }
}
