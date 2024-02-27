void Main()
{
	int[] arr = {1,2,3,4,5,6,7,8};
	Printarray(arr,0);

}

void Printarray(int[] array, int index)
{
	if (index < array.Length)
	{
		Printarray(array, index + 1);
		Console.Write(array[index] + " ");

	}
}

Main();

