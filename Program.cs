// Контрольная работа
string[] array1 = {"Hello", "clear", "I", "Computer", "luv", "Science", "GB" };
int size = array1.Length;
int maxCharactersAllowed = 3;
int howLongMustBeNewArray(string[] array1)
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if(array1[i].Length <= maxCharactersAllowed)
        {
            count = count + 1;
        }
    }
    return count;
}

int sizeOfNewArray = howLongMustBeNewArray(array1);

string[] fillArray(string[] array1)
{
    string[] newArray = new string[sizeOfNewArray];
    int j = 0;
    for(int i = 0; i < size; i++)
    {
        if (array1[i].Length <= maxCharactersAllowed)
        {
            newArray[j] = array1[i];
            j++;
        }
    }
      
    return newArray;
}

string[] newArray1 = fillArray(array1);




