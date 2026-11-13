
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public TextMeshProUGUI scoreText;
    private int coinsCollected = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed ||
                Keyboard.current.upArrowKey.isPressed)
                input.y += 1;

            if (Keyboard.current.sKey.isPressed ||
                Keyboard.current.downArrowKey.isPressed)
                input.y -= 1;

            if (Keyboard.current.aKey.isPressed ||
                Keyboard.current.leftArrowKey.isPressed)
                input.x -= 1;

            if (Keyboard.current.dKey.isPressed ||
                Keyboard.current.rightArrowKey.isPressed)
                input.x += 1;
        }

        Vector3 movement =
            new Vector3(input.x, 0, input.y).normalized;

        rb.AddForce(movement * speed);
    }

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Coin"))
    {
        Destroy(other.gameObject);

        coinsCollected++;
        scoreText.text = "Coins: " + coinsCollected + " / 5";

        if (coinsCollected == 5)
        {
            scoreText.text = "YOU WIN!";
        }
    }
}
}

