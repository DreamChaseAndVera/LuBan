
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


import '/gen/test/Shape.dart';

//圆
 class Circle extends Shape
{
    Circle(
    {
    required this.radius,
    }
    );

    factory Circle.deserialize(dynamic _buf){
        final radius;
        radius = _buf['radius'].toDouble();
        return Circle(
            radius:radius,
       );
    }

    //半径
    final double radius;
    static final int __ID__ = 2131829196;
     @override
    void resolveRef(Tables tables)
    {
        super.resolveRef(tables);

    }

    @override
    String toString() {
        return 'Circle(radius:$radius, )';
    }
}

