
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type TestNotIndexList struct {
    X int32
    Y int32
}

const TypeId_TestNotIndexList = -50446599

func (*TestNotIndexList) GetTypeId() int32 {
    return -50446599
}

func NewTestNotIndexList(_buf *luban.ByteBuf) (_v *TestNotIndexList, err error) {
    _v = &TestNotIndexList{}
    { if _v.X, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Y, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    return
}

