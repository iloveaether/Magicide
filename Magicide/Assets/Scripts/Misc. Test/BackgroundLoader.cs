using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

public class BackgroundLoader : MonoBehaviour
{
	[SerializeField]
	private Vector2Int gridSize = new Vector2Int(100,100);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

		// Load a test grid using Resources.Load
		// NOTE: Apparently using Resources.Load isn't recommended for loading many assets at once, instead you should use AssetBundles:
		// https://docs.unity3d.com/Manual/LoadingResourcesatRuntime.

		// Create the sprite first
		Texture2D background = Resources.Load<Texture2D>("TestGrid");
		Rect dimensions = new Rect(0f, 0f, background.width, background.height);
		Sprite sprite = Sprite.Create(background, dimensions, new Vector2(0, 0));

		// Get the sprite renderer and set the sprite
		var renderer = GetComponent<SpriteRenderer>();
		renderer.sprite = sprite;
		renderer.size = gridSize;

		// Center background
		Transform transform = GetComponent<Transform>();

		Vector2 temp = -gridSize / 2;
		transform.position = new Vector3(temp.x, temp.y, 0);
        transform.eulerAngles = Vector3.zero;
		transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
