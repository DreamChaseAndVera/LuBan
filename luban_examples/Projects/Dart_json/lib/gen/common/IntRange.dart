
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

import 'dart:ffi';
import 'dart:collection';
import '/gen/Tables.dart';



 class IntRange 
{
    IntRange(
    {
    required this.min,
    required this.max,
    }
    );

    factory IntRange.deserialize(dynamic _buf){
        final min;
        min = _buf['min'] as int;
        final max;
        max = _buf['max'] as int;
        return IntRange(
            min:min,
            max:max,
       );
    }

    final int min;
    final int max;
    static final int __ID__ = -751013039;
     
    void resolveRef(Tables tables)
    {

    }

    @override
    String toString() {
        return 'IntRange(min:$min, max:$max, )';
    }
}

