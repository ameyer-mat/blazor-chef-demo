using Microsoft.FSharp.Collections;

namespace ChefApi;

public static class FSharpInterop
{
    public static FSharpList<T> ToFSharpList<T>(this IEnumerable<T> enumerable)
    {
        return ListModule.OfSeq(enumerable);
    }
}