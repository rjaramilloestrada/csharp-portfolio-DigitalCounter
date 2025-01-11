# Digital Counter

C# console application implementing a digital counter with increment/decrement functionality.

## Features
- Increment/decrement operations
- Counter limits
- Step size configuration
- Reset functionality

## Implementation
```csharp
public class DigitalCounter
{
    private int _count;
    private readonly int _maxValue;
    private readonly int _minValue;
    
    public int Count => _count;
    
    public void Increment(int step = 1)
    {
        _count = Math.Min(_count + step, _maxValue);
    }
    
    public void Decrement(int step = 1)
    {
        _count = Math.Max(_count - step, _minValue);
    }
}
```

## Structure
```
DigitalCounter/
├── Program.cs
├── Counter.cs
└── Tests/
    └── CounterTests.cs
```

## Usage
```bash
dotnet run
```

## Testing
```bash
dotnet test
```

## License
MIT License
