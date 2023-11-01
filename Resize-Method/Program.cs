int[] arr = new int[5];

int b = 0;
int newsize(ref int[] arr, int b)
{
    if (b < 0)
    {
        int[] newarr = [arr.length - b];
        return newarr;
    }
    else
    {
        int[] newarr = [arr.length + b];
        return newarr;
    };
};
