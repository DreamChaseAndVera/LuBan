
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

import 'dart:collection';
import '/gen/l10n/PatchDemo.dart';

import '/gen/Tables.dart';


final class TbPatchDemo {
    
    final List<PatchDemo> _dataList = [];
    final Map<int, PatchDemo> _dataMap = {};

    TbPatchDemo(List<dynamic> _array) {
        
        for (var _buf in _array) {

         PatchDemo item = PatchDemo.deserialize(_buf);

         _dataList.add(item);
         _dataMap[item.id] = item;
        }
     }

    PatchDemo? getOrDefault(int id) {
        if (_dataMap.containsKey(id)) {
            return _dataMap[id];
        }
        return null;
    }

    void resolveRef(Tables tables)
    {
      for(var _v in _dataList)
      {
         _v.resolveRef(tables);
      }
    }

}

