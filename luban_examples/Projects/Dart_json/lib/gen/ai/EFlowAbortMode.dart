
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

enum EFlowAbortMode
{


    NONE(0)  ,

    LOWER_PRIORITY(1)  ,

    SELF(2)  ,

    BOTH(3)  ;

    final int value;

    const EFlowAbortMode(this.value);

    static EFlowAbortMode fromValue(int value)
    {
       return EFlowAbortMode.values.firstWhere((element) => element.value == value, orElse: () => fromValue(0));
    }
}

