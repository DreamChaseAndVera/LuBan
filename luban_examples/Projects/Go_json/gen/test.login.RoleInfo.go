
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestLoginRoleInfo struct {
    X1 int32
    X3 int32
    RoleId int64
}

const TypeId_TestLoginRoleInfo = -989153243

func (*TestLoginRoleInfo) GetTypeId() int32 {
    return -989153243
}

func NewTestLoginRoleInfo(_buf map[string]interface{}) (_v *TestLoginRoleInfo, err error) {
    _v = &TestLoginRoleInfo{}
    { var _ok_ bool; var __json_x1__ interface{}; if __json_x1__, _ok_ = _buf["x1"]; !_ok_ || __json_x1__ == nil { err = errors.New("x1 error"); return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x1__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X1 = __x__ }}
    { var _ok_ bool; var __json_x3__ interface{}; if __json_x3__, _ok_ = _buf["x3"]; !_ok_ || __json_x3__ == nil { err = errors.New("x3 error"); return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x3__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X3 = __x__ }}
    { var _ok_ bool; var __json_role_id__ interface{}; if __json_role_id__, _ok_ = _buf["role_id"]; !_ok_ || __json_role_id__ == nil { err = errors.New("role_id error"); return } else { var __x__ int64;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_role_id__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int64(_x_) }; _v.RoleId = __x__ }}
    return
}

