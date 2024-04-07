
namespace IntelliCode.MAUI.Functions;

internal static class UtilityFunctions
{
    internal static void RemoveNumberFromList(List<int> searchList, int valueToRemove)
    {
        searchList.RemoveAll(x => x > valueToRemove);
    }
}
