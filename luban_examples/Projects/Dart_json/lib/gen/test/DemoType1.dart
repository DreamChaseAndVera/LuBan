
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



 class DemoType1 
{
    DemoType1(
    {
    required this.x1,
    }
    );

    factory DemoType1.deserialize(dynamic _buf){
        final x1;
        x1 = _buf['x1'] as int;
        return DemoType1(
            x1:x1,
       );
    }

    final int x1;
    static final int __ID__ = -367048296;
     
    void resolveRef(Tables tables)
    {

    }

    @override
    String toString() {
        return 'DemoType1(x1:$x1, )';
    }
}

