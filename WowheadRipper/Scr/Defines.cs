﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WowheadRipper
{
    public class Defines
    {
        public static string fileName = "";
        public static int programExit = 0;
        public static Queue<string> stream = new Queue<string>();
        private static readonly string[] wowhead_raw_name = new string[] {"zone", "object", "object", "object", "item", "item", "item", "npc", "npc", "npc"
        , "npc"};
        public static readonly string[] id_name = new string[] { "fishing", "contains", "mining", "herbalism", "contains", "milling", "prospecting","drop"
        , "skinning", "pickocketing", "engineering"};
        public static readonly string[] db_name = new string[] { "fishing_loot_temlate", "gameobject_loot_template", "gameobject_loot_template", "gameobject_loot_template"
        , "item_loot_template", "milling_loot_template", "prospecting_loot_template", "creature_loot_template", "skinning_loot_tem", "pickpocketing_loot_template"
        , "engineering_loot_template"};
        public static readonly int maxType = db_name.Length - 1;
        public static string GenerateWowheadUrl(UInt32 type, UInt32 entry) { return string.Format("http://www.wowhead.com/{0}={1}", wowhead_raw_name[type], entry); }
        public static Regex GetDataRegex(UInt32 type)
        {
            switch (type)
            {
                case 0:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'fishing'.*data: (\[.+\])\}\);");
                case 1:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'contains'.*data: (\[.+\])\}\);");
                case 2:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'mining'.*data: (\[.+\])\}\);");
                case 3:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'herbalism'.*data: (\[.+\])\}\);");
                case 4:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'contains'.*data: (\[.+\])\}\);");
                case 5:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'milling'.*data: (\[.+\])\}\);");
                case 6:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'prospecting'.*data: (\[.+\])\}\);");
                case 7:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'drops'.*data: (\[.+\])\}\);");
                case 8:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'skinning'.*data: (\[.+\])\}\);");
                case 9:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'pickpocketing'.*data: (\[.+\])\}\);");
                case 10:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'engineering'.*data: (\[.+\])\}\);");
                default:
                    return new Regex(@"");
            }
        }
        public static Regex GetTotalCountRegex(UInt32 type)
        {
            switch (type)
            {
                case 0:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'fishing'.*_totalCount:");
                case 1:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'contains'.*computeDataFunc:");
                case 2:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'mining'.*_totalCount:");
                case 3:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'herbalism'.*_totalCount:");
                case 4:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'contains'.*_totalCount:");
                case 5:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'milling'.*_totalCount:");
                case 6:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'prospecting'.*_totalCount:");
                case 7:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'drops'.*_totalCount:");
                case 8:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'skinning'.*_totalCount:");
                case 9:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'pickpocketing'.*_totalCount:");
                case 10:
                    return new Regex(@"new Listview\(\{template: 'item', id: 'engineering'.*_totalCount:");
                default:
                    return new Regex(@"");
            }
        }
    }
}