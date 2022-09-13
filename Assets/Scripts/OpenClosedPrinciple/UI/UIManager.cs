using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header ("Inputs")]
    [SerializeField] private TMP_InputField rectangleWidth;
    [SerializeField] private TMP_InputField rectangleHeight;
    [SerializeField] private TMP_InputField squareSide;
    [SerializeField] private TMP_InputField circleRadius;
    
    [Header("Results")]
    [SerializeField] private TextMeshProUGUI rectangleResult;
    [SerializeField] private TextMeshProUGUI squareResult;
    [SerializeField] private TextMeshProUGUI circleResult;

    private string _height;
    private string _width;
    private const string NullValue = "";
    private const string Format = "#.##"; 
    
    public void GetRectangleWidth(string width)
    {
        _width = width;
    }

    public void GetRectangleHeight(string height)
    {
        _height = height;
    }

    public void CalculateRectangleArea()
    {
        try
        {
            var rectangleArea = CalculateManager.Instance.RectangleArea(float.Parse(_width), float.Parse(_height));
            rectangleResult.text = rectangleArea.ToString(Format);
        }
        catch 
        {
            rectangleResult.text = null;
        }
    }
    
    public void CalculateSquareArea(string side)
    {
        if (side != NullValue)
        {
            var squareArea = CalculateManager.Instance.SquareArea(float.Parse(side));
            squareResult.text = squareArea.ToString(Format);
        }
        else
            squareResult.text = null;
    }
    
    public void CalculateCircleArea(string radius)
    {
        if (radius != NullValue)
        {
            var circleArea = CalculateManager.Instance.CircleArea(float.Parse(radius));
            circleResult.text = circleArea.ToString(Format);
        }
        else
            circleResult.text = null;
    }
}
    