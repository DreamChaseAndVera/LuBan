
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

enum AudioType2
{


    UNKNOWN(0)  ,

    ACC(1)  ,

    AIFF(2)  ;

    final int value;

    const AudioType2(this.value);

    static AudioType2 fromValue(int value)
    {
       return AudioType2.values.firstWhere((element) => element.value == value, orElse: () => fromValue(0));
    }
}

