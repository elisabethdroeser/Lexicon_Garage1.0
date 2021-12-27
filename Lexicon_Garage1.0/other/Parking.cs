/*using LexiconGarage1.Vehicles;
public class Parking<T>
{
    private readonly T[] _vehicle;
    private int _currentIndex = -1;

    public Parking() => _vehicle = new T[10];
    
    public int Count => _currentIndex +1;
    public void Push(T vehicle) => _vehicle[++_currentIndex] = vehicle;

    public T Pop() => _vehicle[_currentIndex--];
}
*/