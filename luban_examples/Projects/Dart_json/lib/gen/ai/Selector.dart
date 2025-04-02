
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

import '/gen/ai/Decorator.dart';
import '/gen/ai/Service.dart';
import '/gen/ai/FlowNode.dart';

import '/gen/ai/ComposeNode.dart';

 class Selector extends ComposeNode
{
    Selector(
    {
    required super.id, 
    required super.node_name, 
    required super.decorators, 
    required super.services, 
    required this.children,
    }
    );

    factory Selector.deserialize(dynamic _buf){
        final id;
        id = _buf['id'] as int;
        final node_name;
        node_name = _buf['node_name'] as String;
        final decorators;
        {var _json0 = _buf['decorators'] as List<dynamic>; decorators = List<Decorator>.empty(growable: true); for(var _e0 in _json0) {Decorator _v0; _v0 = Decorator.deserialize(_e0); decorators.add(_v0); } };
        final services;
        {var _json0 = _buf['services'] as List<dynamic>; services = List<Service>.empty(growable: true); for(var _e0 in _json0) {Service _v0; _v0 = Service.deserialize(_e0); services.add(_v0); } };
        final children;
        {var _json0 = _buf['children'] as List<dynamic>; children = List<FlowNode>.empty(growable: true); for(var _e0 in _json0) {FlowNode _v0; _v0 = FlowNode.deserialize(_e0); children.add(_v0); } };
        return Selector(
            id:id,
            node_name:node_name,
            decorators:decorators,
            services:services,
            children:children,
       );
    }

    final List<FlowNode> children;
    static final int __ID__ = -1946981627;
     @override
    void resolveRef(Tables tables)
    {
        super.resolveRef(tables);

        for (var _e in children) { _e?.resolveRef(tables); }
    }

    @override
    String toString() {
        return 'Selector(id:$id, node_name:$node_name, decorators:$decorators, services:$services, children:$children, )';
    }
}

