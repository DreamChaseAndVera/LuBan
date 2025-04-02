
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

import '/gen/test/TestBeRef.dart';
import '/gen/test/TestBeRef.dart';

import '/gen/test/RefDynamicBase.dart';

 class RefBean extends RefDynamicBase
{
    RefBean(
    {
    required super.x, 
    required this.arr,
    }
    );

    factory RefBean.deserialize(dynamic _buf){
        final x;
        x = _buf['x'] as int;
        final arr;
        {var _json0 = _buf['arr'] as List<dynamic>; arr = List<int>.empty(growable: true); for(var _e0 in _json0) {int _v0; _v0 = _e0 as int; arr.add(_v0); } };
        return RefBean(
            x:x,
            arr:arr,
       );
    }

    final List<int> arr;
    List<TestBeRef>? arr_Ref;
    static final int __ID__ = 1963260263;
     @override
    void resolveRef(Tables tables)
    {
        super.resolveRef(tables);

        arr_Ref = List<TestBeRef>.empty(growable: true);
        for (var _v in arr) { var ref=(tables.tbTestBeRef?.getOrDefault(_v))!;arr_Ref?.add(ref); }

    }

    @override
    String toString() {
        return 'RefBean(x:$x, arr:$arr, )';
    }
}

