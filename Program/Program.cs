void Demo(string [] Demoarray)
{
    Console.Write("[");
    for (int j=0; j<Demoarray.Length; j++)
    {
        Console.Write(Demoarray[j] + " ");
    }
    Console.Write("]");
}

string[] array = {"123", "Hello", "world", ":-)"};
int lenArray = array.Length;
string[] array1 = new string [lenArray];
int j=0;
for(int i =0; i < lenArray; i++)
{
    int lenString = array[i].Length;
        if (lenString <= 3)
    {
       array1[j] = array[i];
       j++; 
    }
}
Demo(array1);
