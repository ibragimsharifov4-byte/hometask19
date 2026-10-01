public class Counter
{
    public int Value { get; set; }
    public Counter(int value)
    {
        Value = value;
    }
    public void Decrement()
    {
        if (Value > 0)
        {
            Value--;
        }
    }
    public void Reset()
    {
        Value = 0;
    }
}