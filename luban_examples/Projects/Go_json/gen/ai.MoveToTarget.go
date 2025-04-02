
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type AiMoveToTarget struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    IgnoreRestartSelf bool
    TargetActorKey string
    AcceptableRadius float32
}

const TypeId_AiMoveToTarget = 514987779

func (*AiMoveToTarget) GetTypeId() int32 {
    return 514987779
}

func NewAiMoveToTarget(_buf map[string]interface{}) (_v *AiMoveToTarget, err error) {
    _v = &AiMoveToTarget{}
    { var _ok_ bool; var __json_id__ interface{}; if __json_id__, _ok_ = _buf["id"]; !_ok_ || __json_id__ == nil { err = errors.New("id error"); return } else { var __x__ int32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_id__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = int32(_x_) }; _v.Id = __x__ }}
    { var _ok_ bool; var __json_node_name__ interface{}; if __json_node_name__, _ok_ = _buf["node_name"]; !_ok_ || __json_node_name__ == nil { err = errors.New("node_name error"); return } else { var __x__ string;  {  if __x__, _ok_ = __json_node_name__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.NodeName = __x__ }}
    { var _ok_ bool; var __json_decorators__ interface{}; if __json_decorators__, _ok_ = _buf["decorators"]; !_ok_ || __json_decorators__ == nil { err = errors.New("decorators error"); return } else { var __x__ []interface{};  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok0_ = (__json_decorators__).([]interface{}); !_ok0_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make([]interface{}, 0, len(_arr0_))
                    
                    for _, _e0_ := range _arr0_ {
                        var _list_v0_ interface{}
                        { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e0_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v0_ error"); return }; if _list_v0_, err = NewAiDecorator(_x_); err != nil { return } }
                        __x__ = append(__x__, _list_v0_)
                    }
                }
    ; _v.Decorators = __x__ }}
    { var _ok_ bool; var __json_services__ interface{}; if __json_services__, _ok_ = _buf["services"]; !_ok_ || __json_services__ == nil { err = errors.New("services error"); return } else { var __x__ []interface{};  {
                    var _arr0_ []interface{}
                    var _ok0_ bool
                    if _arr0_, _ok0_ = (__json_services__).([]interface{}); !_ok0_ { err = errors.New("__x__ error"); return }
    
                    __x__ = make([]interface{}, 0, len(_arr0_))
                    
                    for _, _e0_ := range _arr0_ {
                        var _list_v0_ interface{}
                        { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e0_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v0_ error"); return }; if _list_v0_, err = NewAiService(_x_); err != nil { return } }
                        __x__ = append(__x__, _list_v0_)
                    }
                }
    ; _v.Services = __x__ }}
    { var _ok_ bool; var __json_ignore_restart_self__ interface{}; if __json_ignore_restart_self__, _ok_ = _buf["ignore_restart_self"]; !_ok_ || __json_ignore_restart_self__ == nil { err = errors.New("ignore_restart_self error"); return } else { var __x__ bool;  { var _ok_ bool; if __x__, _ok_ = __json_ignore_restart_self__.(bool); !_ok_ { err = errors.New("__x__ error"); return } }; _v.IgnoreRestartSelf = __x__ }}
    { var _ok_ bool; var __json_target_actor_key__ interface{}; if __json_target_actor_key__, _ok_ = _buf["target_actor_key"]; !_ok_ || __json_target_actor_key__ == nil { err = errors.New("target_actor_key error"); return } else { var __x__ string;  {  if __x__, _ok_ = __json_target_actor_key__.(string); !_ok_ { err = errors.New("__x__ error"); return } }; _v.TargetActorKey = __x__ }}
    { var _ok_ bool; var __json_acceptable_radius__ interface{}; if __json_acceptable_radius__, _ok_ = _buf["acceptable_radius"]; !_ok_ || __json_acceptable_radius__ == nil { err = errors.New("acceptable_radius error"); return } else { var __x__ float32;  { var _ok_ bool; var _x_ float64; if _x_, _ok_ = __json_acceptable_radius__.(float64); !_ok_ { err = errors.New("__x__ error"); return }; __x__ = float32(_x_) }; _v.AcceptableRadius = __x__ }}
    return
}

