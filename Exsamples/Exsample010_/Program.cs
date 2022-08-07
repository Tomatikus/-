int [] array = {1,32,63,4,14,15,17,18,};

int n = array.Length;
int find = 18;

int index = 0;

while (index<n)
{
    if (array [index]== find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}