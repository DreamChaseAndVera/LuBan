
/*!
<auto-generated>
    This code was generated by a tool.
    Changes to this file may cause incorrect behavior and will be lost if
    the code is regenerated.
</auto-generated>
*/


use super::*;
use luban_lib::*;

///道具品质
#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EItemQuality {
    ///白
    WHITE = 0,
    ///绿
    GREEN = 1,
    ///蓝
    BLUE = 2,
    ///紫
    PURPLE = 3,
    ///金
    GOLDEN = 4,
}

impl From<i32> for EItemQuality {
    fn from(value: i32) -> Self {
        match value { 
            0 => EItemQuality::WHITE,
            1 => EItemQuality::GREEN,
            2 => EItemQuality::BLUE,
            3 => EItemQuality::PURPLE,
            4 => EItemQuality::GOLDEN,
            _ => panic!("Invalid value for EItemQuality:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum ECurrencyType {
    ///钻石
    DIAMOND = 1,
    ///金币
    GOLD = 2,
    ///银币
    SILVER = 3,
    ///经验
    EXP = 4,
    ///能量点
    POWER_POINT = 5,
}

impl From<i32> for ECurrencyType {
    fn from(value: i32) -> Self {
        match value { 
            1 => ECurrencyType::DIAMOND,
            2 => ECurrencyType::GOLD,
            3 => ECurrencyType::SILVER,
            4 => ECurrencyType::EXP,
            5 => ECurrencyType::POWER_POINT,
            _ => panic!("Invalid value for ECurrencyType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EMajorType {
    ///货币
    CURRENCY = 1,
    ///服装
    CLOTH = 2,
    ///任务
    QUEST = 3,
    ///消耗品
    CONSUMABLES = 4,
    ///宝箱
    TREASURE_BOX = 5,
    ///成就和称谓
    ACHIEVEMENT_AND_TITLE = 6,
    ///头像框
    HEAD_FRAME = 7,
    ///语音
    VOICE = 8,
    ///动作
    ACTION = 9,
    ///扩容道具
    EXPANSION = 10,
    ///制作材料
    MATERIAL = 11,
}

impl From<i32> for EMajorType {
    fn from(value: i32) -> Self {
        match value { 
            1 => EMajorType::CURRENCY,
            2 => EMajorType::CLOTH,
            3 => EMajorType::QUEST,
            4 => EMajorType::CONSUMABLES,
            5 => EMajorType::TREASURE_BOX,
            6 => EMajorType::ACHIEVEMENT_AND_TITLE,
            7 => EMajorType::HEAD_FRAME,
            8 => EMajorType::VOICE,
            9 => EMajorType::ACTION,
            10 => EMajorType::EXPANSION,
            11 => EMajorType::MATERIAL,
            _ => panic!("Invalid value for EMajorType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EMinorType {
    ///钻石
    DIAMOND = 101,
    ///金币
    GOLD = 102,
    ///银币
    SILVER = 103,
    ///经验
    EXP = 104,
    ///能量点
    POWER_POINT = 105,
    ///发型
    HAIR_STYLE = 210,
    ///外套
    COAT = 220,
    ///上衣
    UPPER_JACKET = 230,
    ///裤子
    TROUSERS = 241,
    ///裙子
    SKIRT = 242,
    ///袜子
    SOCKS = 250,
    ///鞋子
    SHOES = 260,
    ///发饰
    HAIR_ACCESSORY = 271,
    ///帽子
    HAT = 272,
    ///耳饰
    EARRING = 273,
    ///颈饰
    NECKLACE = 274,
    ///腕饰
    BRACELET = 275,
    ///发箍
    HAIR_CLASP = 276,
    ///手套
    GLOVE = 277,
    ///手持物
    HANDHELD_OBJECT = 278,
    ///特殊
    SPECIAL = 279,
    ///底妆
    BASE_COSMETIC = 281,
    ///眉妆
    EYEBROW_COSMETIC = 282,
    ///睫毛
    EYELASH = 283,
    ///美瞳
    COSMETIC_CONTACT_LENSES = 284,
    ///唇妆
    LIP_COSMETIC = 285,
    ///肤色
    SKIN_COLOR = 286,
    ///连衣裙
    ONE_PIECE_DRESS = 290,
    ///换装场景
    SWITCH_CLOTHES_SCENE = 291,
    ///任务道具
    QUEST = 301,
    ///投掷物
    CAST = 401,
    ///刀剑
    SWORD = 421,
    ///弓箭
    BOW_ARROW = 422,
    ///法杖
    WANDS = 423,
    ///特殊工具
    SPECIAL_TOOL = 424,
    ///食物
    FOOD = 403,
    ///宝箱
    TREASURE_BOX = 501,
    ///钥匙
    KEY = 502,
    ///多选一宝箱
    MULTI_CHOOSE_TREASURE_BOX = 503,
    ///成就相关
    ACHIEVEMENT = 601,
    ///称谓相关
    TITLE = 602,
    ///头像框
    AVATAR_FRAME = 701,
    ///语音
    VOICE = 801,
    ///特殊待机动作
    IDLE_POSE = 901,
    ///拍照动作
    PHOTO_POSE = 902,
    ///背包
    BAG = 1001,
    ///好友数量
    FRIEND_CAPACITY = 1002,
    ///制作材料
    CONSTRUCTION_MATERIAL = 1101,
    ///设计图纸
    DESIGN_DRAWING = 1102,
}

impl From<i32> for EMinorType {
    fn from(value: i32) -> Self {
        match value { 
            101 => EMinorType::DIAMOND,
            102 => EMinorType::GOLD,
            103 => EMinorType::SILVER,
            104 => EMinorType::EXP,
            105 => EMinorType::POWER_POINT,
            210 => EMinorType::HAIR_STYLE,
            220 => EMinorType::COAT,
            230 => EMinorType::UPPER_JACKET,
            241 => EMinorType::TROUSERS,
            242 => EMinorType::SKIRT,
            250 => EMinorType::SOCKS,
            260 => EMinorType::SHOES,
            271 => EMinorType::HAIR_ACCESSORY,
            272 => EMinorType::HAT,
            273 => EMinorType::EARRING,
            274 => EMinorType::NECKLACE,
            275 => EMinorType::BRACELET,
            276 => EMinorType::HAIR_CLASP,
            277 => EMinorType::GLOVE,
            278 => EMinorType::HANDHELD_OBJECT,
            279 => EMinorType::SPECIAL,
            281 => EMinorType::BASE_COSMETIC,
            282 => EMinorType::EYEBROW_COSMETIC,
            283 => EMinorType::EYELASH,
            284 => EMinorType::COSMETIC_CONTACT_LENSES,
            285 => EMinorType::LIP_COSMETIC,
            286 => EMinorType::SKIN_COLOR,
            290 => EMinorType::ONE_PIECE_DRESS,
            291 => EMinorType::SWITCH_CLOTHES_SCENE,
            301 => EMinorType::QUEST,
            401 => EMinorType::CAST,
            421 => EMinorType::SWORD,
            422 => EMinorType::BOW_ARROW,
            423 => EMinorType::WANDS,
            424 => EMinorType::SPECIAL_TOOL,
            403 => EMinorType::FOOD,
            501 => EMinorType::TREASURE_BOX,
            502 => EMinorType::KEY,
            503 => EMinorType::MULTI_CHOOSE_TREASURE_BOX,
            601 => EMinorType::ACHIEVEMENT,
            602 => EMinorType::TITLE,
            701 => EMinorType::AVATAR_FRAME,
            801 => EMinorType::VOICE,
            901 => EMinorType::IDLE_POSE,
            902 => EMinorType::PHOTO_POSE,
            1001 => EMinorType::BAG,
            1002 => EMinorType::FRIEND_CAPACITY,
            1101 => EMinorType::CONSTRUCTION_MATERIAL,
            1102 => EMinorType::DESIGN_DRAWING,
            _ => panic!("Invalid value for EMinorType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EClothersStarQualityType {
    ///一星
    ONE = 1,
    ///二星
    TWO = 2,
    ///三星
    THREE = 3,
    ///四星
    FOUR = 4,
    ///五星
    FIVE = 5,
    ///六星
    SIX = 6,
    ///七星
    SEVEN = 7,
    ///八星
    EIGHT = 8,
    ///九星
    NINE = 9,
    ///十星
    TEN = 10,
}

impl From<i32> for EClothersStarQualityType {
    fn from(value: i32) -> Self {
        match value { 
            1 => EClothersStarQualityType::ONE,
            2 => EClothersStarQualityType::TWO,
            3 => EClothersStarQualityType::THREE,
            4 => EClothersStarQualityType::FOUR,
            5 => EClothersStarQualityType::FIVE,
            6 => EClothersStarQualityType::SIX,
            7 => EClothersStarQualityType::SEVEN,
            8 => EClothersStarQualityType::EIGHT,
            9 => EClothersStarQualityType::NINE,
            10 => EClothersStarQualityType::TEN,
            _ => panic!("Invalid value for EClothersStarQualityType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EClothersTag {
    ///防晒
    FANG_SHAI = 1,
    ///舞者
    WU_ZHE = 2,
}

impl From<i32> for EClothersTag {
    fn from(value: i32) -> Self {
        match value { 
            1 => EClothersTag::FANG_SHAI,
            2 => EClothersTag::WU_ZHE,
            _ => panic!("Invalid value for EClothersTag:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EUseType {
    ///手动
    MANUAL = 0,
    ///自动
    AUTO = 1,
}

impl From<i32> for EUseType {
    fn from(value: i32) -> Self {
        match value { 
            0 => EUseType::MANUAL,
            1 => EUseType::AUTO,
            _ => panic!("Invalid value for EUseType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EClothesHidePartType {
    ///胸部
    CHEST = 0,
    ///手
    HEAD = 1,
    ///脊柱上
    SPINE_UPPER = 2,
    ///脊柱下
    SPINE_LOWER = 3,
    ///臀部
    HIP = 4,
    ///腿上
    LEG_UPPER = 5,
    ///腿中
    LEG_MIDDLE = 6,
    ///腿下
    LEG_LOWER = 7,
}

impl From<i32> for EClothesHidePartType {
    fn from(value: i32) -> Self {
        match value { 
            0 => EClothesHidePartType::CHEST,
            1 => EClothesHidePartType::HEAD,
            2 => EClothesHidePartType::SPINE_UPPER,
            3 => EClothesHidePartType::SPINE_LOWER,
            4 => EClothesHidePartType::HIP,
            5 => EClothesHidePartType::LEG_UPPER,
            6 => EClothesHidePartType::LEG_MIDDLE,
            7 => EClothesHidePartType::LEG_LOWER,
            _ => panic!("Invalid value for EClothesHidePartType:{}", value),
        }
    }
}

#[derive(Debug, Hash, Eq, PartialEq, macros::EnumFromNum)]
pub enum EClothesPropertyType {
    ///简约
    JIAN_YUE = 1,
    ///华丽
    HUA_LI = 2,
    ///可爱
    KE_AI = 3,
    ///成熟
    CHENG_SHU = 4,
    ///活泼
    HUO_PO = 5,
    ///优雅
    YOU_YA = 6,
    ///清纯
    QING_CHUN = 7,
    ///性感
    XING_GAN = 8,
    ///清凉
    QING_LIANG = 9,
    ///保暖
    BAO_NUAN = 10,
}

impl From<i32> for EClothesPropertyType {
    fn from(value: i32) -> Self {
        match value { 
            1 => EClothesPropertyType::JIAN_YUE,
            2 => EClothesPropertyType::HUA_LI,
            3 => EClothesPropertyType::KE_AI,
            4 => EClothesPropertyType::CHENG_SHU,
            5 => EClothesPropertyType::HUO_PO,
            6 => EClothesPropertyType::YOU_YA,
            7 => EClothesPropertyType::QING_CHUN,
            8 => EClothesPropertyType::XING_GAN,
            9 => EClothesPropertyType::QING_LIANG,
            10 => EClothesPropertyType::BAO_NUAN,
            _ => panic!("Invalid value for EClothesPropertyType:{}", value),
        }
    }
}

#[derive(Debug)]
pub struct Item {
    /// 道具id
    pub id: i32,
    pub name: String,
    pub major_type: crate::item::EMajorType,
    pub minor_type: crate::item::EMinorType,
    pub max_pile_num: i32,
    pub quality: crate::item::EItemQuality,
    pub icon: String,
    pub icon_backgroud: String,
    pub icon_mask: String,
    pub desc: String,
    pub show_order: i32,
}

impl Item{
    pub fn new(mut buf: &mut ByteBuf) -> Result<Item, LubanError> {
        let id = buf.read_int();
        let name = buf.read_string();
        let major_type = buf.read_int().into();
        let minor_type = buf.read_int().into();
        let max_pile_num = buf.read_int();
        let quality = buf.read_int().into();
        let icon = buf.read_string();
        let icon_backgroud = buf.read_string();
        let icon_mask = buf.read_string();
        let desc = buf.read_string();
        let show_order = buf.read_int();
        
        Ok(Item { id, name, major_type, minor_type, max_pile_num, quality, icon, icon_backgroud, icon_mask, desc, show_order, })
    }

    pub const __ID__: i32 = 2107285806;
}


///道具表
#[derive(Debug)]
pub struct TbItem {
    pub data_list: Vec<std::sync::Arc<crate::item::Item>>,
    pub data_map: std::collections::HashMap<i32, std::sync::Arc<crate::item::Item>>,
}

impl TbItem {
    pub fn new(mut buf: ByteBuf) -> Result<std::sync::Arc<TbItem>, LubanError> {
        let mut data_map: std::collections::HashMap<i32, std::sync::Arc<crate::item::Item>> = Default::default();
        let mut data_list: Vec<std::sync::Arc<crate::item::Item>> = vec![];

        for x in (0..buf.read_size()).rev() {
            let row = std::sync::Arc::new(crate::item::Item::new(&mut buf)?);
            data_list.push(row.clone());
            data_map.insert(row.id.clone(), row.clone());
        }

        Ok(std::sync::Arc::new(TbItem { data_map, data_list }))
    }

    pub fn get(&self, key: &i32) -> Option<std::sync::Arc<crate::item::Item>> {
        self.data_map.get(key).map(|x| x.clone())
    }
}

impl std::ops::Index<i32> for TbItem {
    type Output = std::sync::Arc<crate::item::Item>;

    fn index(&self, index: i32) -> &Self::Output {
        &self.data_map.get(&index).unwrap()
    }
}


