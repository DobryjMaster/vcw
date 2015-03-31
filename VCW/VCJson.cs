using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace VCW.Users
{
    public class UsersAppAuthResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
    }

    public class UsersShortInfosResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public List<City> cities { get; set; }
        public Quests quests { get; set; }
        public List<object> injured { get; set; }
        public int traumasEffect { get; set; }
        public List<EatEffect> eatEffects { get; set; }

        public class User
        {
            public User2 User { get; set; }
            public UserLevel UserLevel { get; set; }

            public class User2
            {
                public int id { get; set; }
                public int avatar { get; set; }
                public string username { get; set; }
                public string vd_balance { get; set; }
                public string vg_balance { get; set; }
                public string max_health { get; set; }
                public string health { get; set; }
                public string energy { get; set; }
                public string max_energy { get; set; }
                public int prestige { get; set; }
                public string social_status_title { get; set; }
                public string social_status { get; set; }
                public int city_id { get; set; }
                public string city_name { get; set; }
                public string party_name { get; set; }
                public int last_up_energy { get; set; }
                public int delta_recovery_energy { get; set; }
            }

            public class UserLevel
            {
                public int level { get; set; }
            }
        }

        public class City
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Quests
        {
            public int completed { get; set; }
            public List<Npc> npcs { get; set; }
            public List<object> list { get; set; }

            public class Npc
            {
                public string id { get; set; }
                public string img { get; set; }
            }
        }

        public class EatEffect : IEquatable<EatEffect>
        {
            public Item item { get; set; }
            public int bonus { get; set; }
            public int end { get; set; }

            public class Item
            {
                public string name_ru { get; set; }
                public string image { get; set; }
                public string name { get; set; }
            }

            public bool Equals(EatEffect other)
            {
                if (0 == String.Compare(this.item.name, other.item.name, StringComparison.OrdinalIgnoreCase) && this.bonus == other.bonus)
                    return true;
                else
                    return false;
            }
        } 
    }

    public class UsersCheckResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public bool energyUpdated { get; set; }
    }
}
namespace VCW.BigFights
{
    public class BigFightsSilentViewResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public bool error { get; set; }
        public bool active { get; set; }
        public List<object> bigFight { get; set; }
        public List<object> bigFightMember { get; set; }
        public List<object> top { get; set; }
    }
}
namespace VCW.CityElections
{
    public class CityElectionsSilentViewResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public bool active { get; set; }
        public bool mayor { get; set; }
        public bool parliament { get; set; }
    }
}
namespace VCW.PrestigeWars
{
    public class PrestigeWarsSilentViewResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public bool active { get; set; }
    }
}
namespace VCW.Newspapers
{
    public class NewspapersLatestSubscriptionsPostResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public NewspaperPost NewspaperPost { get; set; }
        public Newspaper Newspaper { get; set; }

        public class NewspaperPost
        {
            public int id { get; set; }
            public int newspaper_id { get; set; }
            public string title { get; set; }
            public string main_quote { get; set; }
            public string short_body { get; set; }
            public string body { get; set; }
            public int created { get; set; }
            public int updated { get; set; }
            public string user_likes { get; set; }
            public int likes { get; set; }
            public int moderated { get; set; }
            public int experience { get; set; }
            public int newspaper_post_comment_count { get; set; }
            public bool hidden { get; set; }
        }

        public class Newspaper
        {
            public int id { get; set; }
            public int user_id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public int show_ads { get; set; }
            public string user_advert { get; set; }
            public int advert_status { get; set; }
            public string moderator_notes { get; set; }
            public object created { get; set; }
            public int updated { get; set; }
            public int newspaper_subscription_count { get; set; }
            public bool admin_paper { get; set; }
            public User User { get; set; }

            public class User
            {
                public int id { get; set; }
                public int created { get; set; }
                public int updated { get; set; }
                public string username { get; set; }
                public string password { get; set; }
                public string email { get; set; }
                public string fio { get; set; }
                public string activation { get; set; }
                public string vd_balance { get; set; }
                public string vg_balance { get; set; }
                public string health { get; set; }
                public string max_health { get; set; }
                public int current_fight { get; set; }
                public int last_fight { get; set; }
                public int honor { get; set; }
                public string fight_points { get; set; }
                public string sex { get; set; }
                public string avatar { get; set; }
                public int rest { get; set; }
                public int hunger { get; set; }
                public int msg_count { get; set; }
                public int worked_today { get; set; }
                public int trained_today { get; set; }
                public int fished_today { get; set; }
                public int upload_limit { get; set; }
                public string energy { get; set; }
                public int prestige { get; set; }
                public int ref_id { get; set; }
                public object ref_amount { get; set; }
                public int change_username { get; set; }
                public int last_login { get; set; }
                public int next_fight_offer { get; set; }
                public string birthday { get; set; }
                public string phone { get; set; }
                public string about_youself { get; set; }
                public int show_user_detail { get; set; }
                public string localization { get; set; }
                public int get_info_by_phone { get; set; }
                public int get_info_by_email { get; set; }
                public string icq { get; set; }
                public string skype { get; set; }
                public int ban_to { get; set; }
                public int is_ban { get; set; }
                public int city_id { get; set; }
                public string helps { get; set; }
                public string country { get; set; }
                public string city { get; set; }
                public int inv_size { get; set; }
                public string sn_infos { get; set; }
                public int mailing { get; set; }
                public int in_election { get; set; }
                public int trained_all { get; set; }
                public int resting { get; set; }
                public int start_rest { get; set; }
                public object last_award { get; set; }
                public int first_login { get; set; }
                public int next_pvp_bot_fight { get; set; }
                public string max_energy { get; set; }
                public int last_up_energy { get; set; }
                public int delta_recovery_energy { get; set; }
                public int military_rank_id { get; set; }
                public int caused_damage { get; set; }
                public int military_medals { get; set; }
            }
        }
    }
}
namespace VCW.Quests
{
    public class QuestsUserQuestsResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public List<object> newQuests { get; set; }
        public List<object> completedQuests { get; set; }
        public List<Npc> npcs { get; set; }
        public List<NpcQuestsInProgress> npcQuestsInProgress { get; set; }
        public Daily daily { get; set; }

        public class Npc
        {
            public string id { get; set; }
            public string img { get; set; }
        }

        public class NpcQuestsInProgress
        {
            public UserQuest UserQuest { get; set; }
            public Quest Quest { get; set; }
            public List<Condition> conditions { get; set; }

            public class UserQuest
            {
                public int quest_id { get; set; }
                public int? day { get; set; }
            }

            public class Quest
            {
                public string name { get; set; }
                public int npc_id { get; set; }
                public int id { get; set; }
            }

            public class Condition
            {
                public string name { get; set; }
                public string title { get; set; }
                public int completeValue { get; set; }
                public int currentValue { get; set; }
                public bool completed { get; set; }
                public double percent { get; set; }
            }
        }

        public class Daily
        {
            public DailyQuest Quest { get; set; }
            public int day { get; set; }
            public List<DailyQuestCondition> conditions { get; set; }

            public class DailyQuest
            {
                public int id { get; set; }
                public int quest_group_id { get; set; }
                public string name { get; set; }
                public string title_ru { get; set; }
                public string title_en { get; set; }
                public string number { get; set; }
                public int daily { get; set; }
                public int updated { get; set; }
                public int created { get; set; }
                public object finish_text_ru { get; set; }
                public object finish_text_en { get; set; }
                public int failed { get; set; }
                public object complete_date { get; set; }
                public int is_training { get; set; }
                public int npc_id { get; set; }
            }

            public class DailyQuestCondition
            {
                public string name { get; set; }
                public string title { get; set; }
                public int completeValue { get; set; }
                public int currentValue { get; set; }
                public bool completed { get; set; }
                public int percent { get; set; }
            }
        }  
    }
}
namespace VCW.UserItems
{
    public class UserItemsStorageResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public string max { get; set; }
        public int current { get; set; }
        public Storage storage { get; set; }
        public User User { get; set; }
        public ExpandInfo expandInfo { get; set; }

        public class Storage
        {
            public List<ItemsArray> itemsArray { get; set; }
            public int inventorySize { get; set; }

            [DataMember]
            public class ItemsArray
            {
                [DataContract(Name = "UserItem")]
                public UserItem userItem { get; set; }
                [DataContract(Name = "ItemType")]
                public ItemType itemType { get; set; }

                public class UserItem
                {
                    public int id { get; set; }
                    public int expires { get; set; }
                    public int strength { get; set; }
                    public int user_id { get; set; }
                    public int equipped { get; set; }
                    public string equipped_slot { get; set; }
                    public int quantity { get; set; }
                }

                public class ItemType
                {
                    public int id { get; set; }
                    public string name_ru { get; set; }
                    public string name_en { get; set; }
                    public string @class { get; set; }
                    public EnumItemType type { get; set; }  // string
                    public string image { get; set; }
                    public int can_use { get; set; }
                    public int special { get; set; }
                    public string name { get; set; }
                }
            }
        }

        public class User
        {
            public string avatar { get; set; }
        }

        public class ExpandInfo
        {
            public string size_step { get; set; }
            public string step_cost { get; set; }
        }
    }

    public class UserItemsGetInfoResult
    {
        public List<object> setFlash { get; set; }
        public string town { get; set; }
        public ItemInfo itemInfo { get; set; }
        public string effect { get; set; }

        [DataMember]
        public class ItemInfo
        {
            [DataContract(Name = "ItemType")]
            public ItemType itemType { get; set; }
            [DataContract(Name = "ItemTypeCategory")]
            public ItemTypeCategory itemTypeCategory { get; set; }
            [DataContract(Name = "UserItem")]
            public UserItem userItem { get; set; }

            public class ItemType
            {
                public int id { get; set; }
                public string name_ru { get; set; }
                public string image { get; set; }
                // Item type
                public string type { get; set; }
                public int receipt_id { get; set; }
                public string min_damage { get; set; }
                public string max_damage { get; set; }
                public int min_range { get; set; }
                public int max_range { get; set; }
                public string fire_speed { get; set; }
                public string hp_bonus { get; set; }
                public int energy_bonus { get; set; }
                public string add_energy { get; set; }
                public string restore_energy { get; set; }
                public int prestige { get; set; }
                public string bonus_damage { get; set; }
                public string critical { get; set; }
                public string anticritical { get; set; }
                public string dodge { get; set; }
                public string antidodge { get; set; }
                public string dmg_absorb { get; set; }
                // Bonus to delta_recovery_energy
                public int energy_rest_speed_bonus { get; set; }
                // Expire in seconds
                public int energy_rest_speed_expire { get; set; }
                public int strength_val { get; set; }
                public int user_creator_id { get; set; }
                public object ammunition_id { get; set; }
                // Stack size
                public int quantity_in_stack { get; set; }
                public int special { get; set; }
                public string weapon_type { get; set; }
                public int can_use { get; set; }
                public string @class { get; set; }
                public string name { get; set; }
                public string description { get; set; }
            }

            public class ItemTypeCategory
            {
                public EnumItemTypeCategory name { get; set; } //string
            }

            public class UserItem
            {
                public int id { get; set; }
                public int item_type_id { get; set; }
                public int user_id { get; set; }
                public int quantity { get; set; }
                public int city_id { get; set; }
                public int equipped { get; set; }
                public string equipped_slot { get; set; }
                public int expires { get; set; }
                public int strength { get; set; }
                public int created { get; set; }
                public int updated { get; set; }
                public int equipped_time { get; set; }
                public int master_id { get; set; }
            }
        }
    }

    public class UserItemsEatUserItemResult
    {
        public List<SetFlash> setFlash { get; set; }
        public string town { get; set; }
        public int error { get; set; }

        public class SetFlash
        {
            public string msg { get; set; }
            public string @class { get; set; }
        }
    }

    [DataMember]
    public enum EnumItemType
    {
        [DataContract(Name = "food")]
        FOOD,
        [DataContract(Name = "comfortFurniture")]
        COMFORT_FURNITURE,
        [DataContract(Name = "vintageFurniture")]
        VINTAGE_FURNITURE,
        [DataContract(Name = "jewelry")]
        JEWELRY,
        [DataContract(Name = "clothes")]
        CLOTHES,
        [DataContract(Name = "weapon")]
        WEAPON,
        [DataContract(Name = "ammunition")]
        AMMUNITION,
    }

    /// <summary>
    /// ItemTypeCategory for food
    /// </summary>
    [DataMember]
    public enum EnumItemTypeCategory
    {
        #region food
        /// <summary>
        /// Молоко
        /// Молоко (Milk),
        /// </summary>
        [DataContract(Name = "Молоко")]
        MILK,
        /// <summary>
        /// Мясо
        /// Мясо (Meat), 
        /// </summary>
        [DataContract(Name = "Мясо")]
        MEAT,
        /// <summary>
        /// Полноценный обед
        /// Пицца "Рыбацкая" (Fisher's pizza),
        /// </summary>
        [DataContract(Name = "Полноценный обед")]
        FULL_LUNCH,
        /// <summary>
        /// Кулинария
        /// Мясная булка (Meat bread),
        /// </summary>
        [DataContract(Name = "Кулинария")]
        COOKERY,
        /// <summary>
        /// Рыба
        /// Рыба (Fish),
        /// </summary>
        [DataContract(Name = "Рыба")]
        FISH,
        /// <summary>
        /// Зерно
        /// Овощи (Vegetables), Зерно (Grain)
        /// </summary>
        [DataContract(Name = "Зерно")]
        GRAIN,
        /// <summary>
        /// Горячие блюда
        /// Жаркое (Stew),
        /// </summary>
        [DataContract(Name = "Горячие блюда")]
        HOT_DISHES,
        /// <summary>
        /// Закуска
        /// Рыбный пирог (Fish pie),
        /// </summary>
        [DataContract(Name = "Закуска")]
        SNACK,
        #endregion food
    }
}