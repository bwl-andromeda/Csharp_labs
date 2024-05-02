class Array
{
    private int[] array;

    public Array(int[] array)
    {
        this.array = array;
    }
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException();
            return array[index];
        }
        set
        {
            if (index < 0 && index >= array.Length)
                throw new IndexOutOfRangeException();
            array[index] = value;
        }
    }
    public int Length
    {
        get { return array.Length; }
    }
    public void ReplaceMaxElement()
    {
        int maxindex = 0;
        int maxvalue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxvalue)
            {
                maxvalue = array[i];
                maxindex = i;
            }
        }
        int temp = array[0];
        array[0] = array[maxindex];
        array[maxindex] = temp;
    }
}

class Program
{
    static void Main()
    {
        Array array = new Array(new int[] { 3, 7, 2, 9, 5 });
        array.ReplaceMaxElement();
        Console.WriteLine("Массив после замены:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}