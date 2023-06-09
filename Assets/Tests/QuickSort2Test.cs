using NUnit.Framework;

public class QuickSort2Test
{
    [Test]
    public void QuickSort2TestSimplePasses()
    {
        int[] array = new int[] { 7, 2, 16, 1, -1, 7, 2, 2, 3, 6 };
        int[] expected = new int[] { -1, 1, 2, 2, 2, 3, 6, 7, 7, 16 };
        QuickSort2.QuickSort(array);
        ArrayHelper.PrintArray(array);
        Assert.AreEqual(array, expected);
    }
}