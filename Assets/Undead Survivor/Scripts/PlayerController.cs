using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float inputHorizontal;
    private float inputVertical;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(inputHorizontal, inputVertical, 0f).normalized;
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }


}
