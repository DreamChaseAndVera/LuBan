
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

enum ETestEmptyEnum
{
    empty_placeholder(0);


    final int value;

    const ETestEmptyEnum(this.value);

    static ETestEmptyEnum fromValue(int value)
    {
       return ETestEmptyEnum.values.firstWhere((element) => element.value == value, orElse: () => fromValue(0));
    }
}

