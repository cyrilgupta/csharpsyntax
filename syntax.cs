namespace DoTeam.Server.Classes;

public class Declarations
{
    int myInt = 0, yourInt = 1, theirInt = 2;

    public int Increment(int myNum)
    {
        myNum++;
        return myNum;
    }

    private void Incremenet2()
    {
        goto MyLabels;

        myInt = Increment(myInt);
        string myString = "this is an string";
        char chary = 'A';
        int[] ints = new int[10];

#if DEBUG

        switch (myInt)
        {
            case 0:
                myString = "Myint is 0";
                break;
            case 1:
                myString = "Myint is 1";
        }
#elif !DEBUG
        switch (myInt)
        {
            case 0:
                myString = "Myint is 0";
                break;
            case 1:
                myString = "Myint is 1";
        }

#endif

        var person = new
        {
            Name = "Jeet",
            Age = 42
        };
        

MyLabels:
        myInt = 0;
    }

    public void SubtractMe()
    {
        myInt--;

        for (int i = 0; i < myInt; i++)
        {

        }

    }

}

public struct Mystruct
{

}

public record MyRecord
{

}

