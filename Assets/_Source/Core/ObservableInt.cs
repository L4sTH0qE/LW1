namespace _Source.Core
{
  public class ObservableInt
  {
    public event System.Action<object> OnChanged;

    private int _value;

    public int Value
    {
      get => _value;
      set
      {
        _value = value;
        OnChanged?.Invoke(value);
      }
    }
    
    public ObservableInt()
    {
      _value = 0;
    }
    
    public ObservableInt(int value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
  }
}