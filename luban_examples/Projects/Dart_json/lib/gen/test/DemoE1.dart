
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


import '/gen/test/DemoD3.dart';

 class DemoE1 extends DemoD3
{
    DemoE1(
    {
    required super.x1, 
    required super.x3, 
    required this.x4,
    }
    );

    factory DemoE1.deserialize(dynamic _buf){
        final x1;
        x1 = _buf['x1'] as int;
        final x3;
        x3 = _buf['x3'] as int;
        final x4;
        x4 = _buf['x4'] as int;
        return DemoE1(
            x1:x1,
            x3:x3,
            x4:x4,
       );
    }

    final int x4;
    static final int __ID__ = -2138341717;
     @override
    void resolveRef(Tables tables)
    {
        super.resolveRef(tables);

    }

    @override
    String toString() {
        return 'DemoE1(x1:$x1, x3:$x3, x4:$x4, )';
    }
}

