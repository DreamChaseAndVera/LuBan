
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

type vec4 struct {
    X float32
    Y float32
    Z float32
    W float32
}

const TypeId_vec4 = 3615520

func (*vec4) GetTypeId() int32 {
    return 3615520
}

func Newvec4(_buf *luban.ByteBuf) (_v *vec4, err error) {
    _v = &vec4{}
    { if _v.X, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.Y, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.Z, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.W, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    return
}

