
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestExcelFromJson struct {
    X4 int32
    X1 bool
    X5 int64
    X6 float32
    S1 string
    S2 string
    T1 int64
    X12 *TestDemoType1
    X13 int32
    X14 interface{}
    K1 []int32
    K8 map[int32]int32
    K9 []*TestDemoE2
    K15 []interface{}
}

const TypeId_TestExcelFromJson = -1485706483

func (*TestExcelFromJson) GetTypeId() int32 {
    return -1485706483
}

func NewTestExcelFromJson(_buf map[string]interface{}) (_v *TestExcelFromJson, err error) {
    _v = &TestExcelFromJson{}
    { var _ok_ bool; var __json_x4__ interface{}; if __json_x4__, _ok_ = _buf["x4"]; !_ok_ || __json_x4__ == nil { err = errors.New("x4 error"); return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x4__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X4 = __x__ }}
    { var _ok_ bool; var __json_x1__ interface{}; if __json_x1__, _ok_ = _buf["x1"]; !_ok_ || __json_x1__ == nil { err = errors.New("x1 error"); return } else { var __x__ bool;  { var _ok_ bool; if __x__, _ok_ = __json_x1__.(bool); !_ok_ { err = errors.New("__x__ error"); return } }; _v.X1 = __x__ }}
    { var _ok_ bool; var __json_x5__ interface{}; if __json_x5__, _ok_ = _buf["x5"]; !_ok_ || __json_x5__ == nil { err = errors.New("x5 error"); return } else { var __x__ int64;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x5__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int64(_x_) }; _v.X5 = __x__ }}
    { var _ok_ bool; var __json_x6__ interface{}; if __json_x6__, _ok_ = _buf["x6"]; !_ok_ || __json_x6__ == nil { err = errors.New("x6 error"); return } else { var __x__ float32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x6__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = float32(_x_) }; _v.X6 = __x__ }}
    { var _ok_ bool; var __json_s1__ interface{}; if __json_s1__, _ok_ = _buf["s1"]; !_ok_ || __json_s1__ == nil { err = errors.New("s1 error"); return } else { var __x__ string;  {  if __x__, _ok_ = __json_s1__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.S1 = __x__ }}
    { var _ok_ bool; var __json_s2__ interface{}; if __json_s2__, _ok_ = _buf["s2"]; !_ok_ || __json_s2__ == nil { err = errors.New("s2 error"); return } else { var __x__ string;  {  if __x__, _ok_ = __json_s2__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.S2 = __x__ }}
    { var _ok_ bool; var __json_t1__ interface{}; if __json_t1__, _ok_ = _buf["t1"]; !_ok_ || __json_t1__ == nil { err = errors.New("t1 error"); return } else { var __x__ int64;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_t1__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int64(_x_) }; _v.T1 = __x__ }}
    { var _ok_ bool; var __json_x12__ interface{}; if __json_x12__, _ok_ = _buf["x12"]; !_ok_ || __json_x12__ == nil { err = errors.New("x12 error"); return } else { var __x__ *TestDemoType1;  { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = __json_x12__.(map[string]interface{}); !_ok_ { err = errors.New("__x__ error"); return }; if __x__, err = NewTestDemoType1(_x_); err != nil { return } }; _v.X12 = __x__ }}
    { var _ok_ bool; var __json_x13__ interface{}; if __json_x13__, _ok_ = _buf["x13"]; !_ok_ || __json_x13__ == nil { err = errors.New("x13 error"); return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_x13__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.X13 = __x__ }}
    { var _ok_ bool; var __json_x14__ interface{}; if __json_x14__, _ok_ = _buf["x14"]; !_ok_ || __json_x14__ == nil { err = errors.New("x14 error"); return } else { var __x__ interface{};  { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = __json_x14__.(map[string]interface{}); !_ok_ { err = errors.New("__x__ error"); return }; if __x__, err = NewTestDemoDynamic(_x_); err != nil { return } }; _v.X14 = __x__ }}
    { var _ok_ bool; var __json_k1__ interface{}; if __json_k1__, _ok_ = _buf["k1"]; !_ok_ || __json_k1__ == nil { err = errors.New("k1 error"); return } else { var __x__ []int32;  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok0_ = (__json_k1__).([]interface{}); !_ok0_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make([]int32, 0, len(_arr0_))
                    
                    for _, _e0_ := range _arr0_ {
                        var _list_v0_ int32
                        { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e0_.(float64); !_ok_ { err = errors.New("_list_v0_ error"); return }; _list_v0_ = int32(_x_) }
                        __x__ = append(__x__, _list_v0_)
                    }
                }
    ; _v.K1 = __x__ }}
    { var _ok_ bool; var __json_k8__ interface{}; if __json_k8__, _ok_ = _buf["k8"]; !_ok_ || __json_k8__ == nil { err = errors.New("k8 error"); return } else { var __x__ map[int32]int32;  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok_ = (__json_k8__).([]interface{}); !_ok_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make(map[int32]int32)
                    
                    for _, _e0_ := range _arr0_ {
                        var _kv0_ []interface{}
                        if _kv0_, _ok0_ = _e0_.([]interface{}); !_ok0_ || len(_kv0_) != 2 { err = errors.New("__x__ error"); return }
                        var _key0_ int32
                        { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv0_[0].(float64); !_ok_ { err = errors.New("_key0_ error"); return }; _key0_ = int32(_x_) }
                        var _value0_ int32
                        { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv0_[1].(float64); !_ok_ { err = errors.New("_value0_ error"); return }; _value0_ = int32(_x_) }
                        __x__[_key0_] = _value0_
                    }
                    }; _v.K8 = __x__ }}
    { var _ok_ bool; var __json_k9__ interface{}; if __json_k9__, _ok_ = _buf["k9"]; !_ok_ || __json_k9__ == nil { err = errors.New("k9 error"); return } else { var __x__ []*TestDemoE2;  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok0_ = (__json_k9__).([]interface{}); !_ok0_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make([]*TestDemoE2, 0, len(_arr0_))
                    
                    for _, _e0_ := range _arr0_ {
                        var _list_v0_ *TestDemoE2
                        { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e0_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v0_ error"); return }; if _list_v0_, err = NewTestDemoE2(_x_); err != nil { return } }
                        __x__ = append(__x__, _list_v0_)
                    }
                }
    ; _v.K9 = __x__ }}
    { var _ok_ bool; var __json_k15__ interface{}; if __json_k15__, _ok_ = _buf["k15"]; !_ok_ || __json_k15__ == nil { err = errors.New("k15 error"); return } else { var __x__ []interface{};  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok0_ = (__json_k15__).([]interface{}); !_ok0_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make([]interface{}, 0, len(_arr0_))
                    
                    for _, _e0_ := range _arr0_ {
                        var _list_v0_ interface{}
                        { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e0_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v0_ error"); return }; if _list_v0_, err = NewTestDemoDynamic(_x_); err != nil { return } }
                        __x__ = append(__x__, _list_v0_)
                    }
                }
    ; _v.K15 = __x__ }}
    return
}

